using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageReset : MonoBehaviour
{
    GameObject stage1boss;
    float time = 0;
    bool a = false;
    bool stage = false;
    public bool inst = false;
    //int StageNum = 1;
    //bool down = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(stage1boss == null && !inst)
        {
            stage1boss = GameObject.Find("kurumeusu2(Clone)");
            inst = true;
        }


        if (EnemyMove.bossHp == 0 && inst)
        {
            if (!a)
            {
                Debug.Log("bossBreak!");
                imageTest.kari += 10000000;
                imageTest.scorejudge = 1;
                a = true;
            }

            //time += Time.deltaTime;
            //Debug.Log(time);
            //if (time > 5 && !stage)
            //{
            StageManager.stage++;
            //Debug.Log("stage" + StageManager.stage);

            time = 0;
            stage = true;
            inst = false;
            EnemyMove.bossHp = 1;
            if (StageManager.stage < 6)
                SceneManager.LoadScene("Stage" + StageManager.stage);//ここステージクリアしたら次のステージへ
            else
                SceneManager.LoadScene("tutorial");
            //SceneManager.LoadScene("GameClearScene");
            //}
        }
        
        
    }
}
