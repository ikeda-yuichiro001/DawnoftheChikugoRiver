using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    //GameObject Bullet;
    //GameObject BigBullet;
    //bool bomblimit = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Bullet = GameObject.FindWithTag("Respawn");
        //BigBullet = GameObject.Find("enemy_bul_big(Clone)");

        if (Input.GetKeyDown(KeyCode.X) && ScoreMangers.Boom > 0)
        {
            //bomblimit = true;
            //float t = 0;
            //t += Time.deltaTime;
            ScoreMangers.Boom--;
            GameObject a = Instantiate(Resources.Load("BombShot!!"), transform.position, Quaternion.identity) as GameObject;
            //----------------------------------------------------
            //自機からすっけすけの弾が出て広がって何秒か後には消滅

        }
        if (Input.GetKeyDown(KeyCode.X) && ScoreMangers.Boom < 0)
        {
            Debug.Log("ボム使えない！");
        }
    }
}
