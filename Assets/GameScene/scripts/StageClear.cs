using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    GameObject stage1boss;
    float time = 0;
    bool a = false;
    bool b = false;
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

            
            //{
            if (SceneManager.GetActiveScene().name != "trial" && !b)
            {
                StageManager.stage++;
                b = true;
            }
            //Debug.Log("stage" + StageManager.stage);
            
            

            time += Time.deltaTime;
            //Debug.Log(time);
            if (time > 5)
            {
                if (StageManager.stage < 6) {
                    inst = false;
                    stage = true;
                    EnemyMove.bossHp = 1;
                    SceneManager.LoadScene("Stage" + StageManager.stage);//ここステージクリアしたら次のステージへ
                }
                if (StageManager.stage > 6)
                {
                    inst = false;
                    stage = true;
                    EnemyMove.bossHp = 1;
                    SceneManager.LoadScene("trial");
                }
                if (StageManager.stage == 6)
                {
                    inst = false;
                    stage = true;
                    EnemyMove.bossHp = 1;
                    SceneManager.LoadScene("GameClear");
                }
            }
            //SceneManager.LoadScene("GameClearScene");
            //}
        }
        
        
    }
}
