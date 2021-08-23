using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_Behavior : MonoBehaviour
{
    public int phase;
    public EnemyController enemyCtrler;

    public virtual void SETUP(){ Debug.Log("SETUP is not override"); }
    public virtual void UPDATE() { Debug.Log("UPDATE is not override"); }

    // Start is called before the first frame update
    public void Start()
    {
        enemyCtrler = GetComponent<EnemyController>();
        player = GameObject.Find("player");
        SETUP();
    }

    public float PlayerDistance;

    float timer;
    float timerCnt;
    bool timerFlag;

    public GameObject player;

    public void Update()
    {
        Debug.Log(player_ctrl.pc.transform.position);
        Debug.Log(transform.position);
        PlayerDistance = Vector3.Distance(player_ctrl.pc.gameObject.transform.position, transform.position);
        if (timerFlag)
        {
            timerCnt += Time.deltaTime;
            if(timer <= timerCnt)
            {
                timerCnt = 0;
                timerFlag = false;
            }
        }
        UPDATE();
    }

    public void TimerOn(float c)
    {
        timer = c;
        timerFlag = true;
    }

    public bool IsFinishedTimer
    {
        get
        {
            return !timerFlag;
        }

    }

    protected void NextPreparation(Action action, AttackPattern attack)
    {
        enemyCtrler.action = action;
        enemyCtrler.pattern = attack;
    }
    protected void NextPreparation(Action action, AttackPattern attack, float t)
    {
        TimerOn(t);
        NextPreparation(action, attack);
    }
}
