using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    GameObject stage1boss;
    float time = 0;
    bool a = false;
    bool stage = false;
    int StageNum = 1;
    //bool down = false;
    // Start is called before the first frame update
    void Start()
    {
        stage1boss = GameObject.Find("kurumeusu");
        stage = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( stage1boss == null)
        {
            if (!a)
            {
                imageTest.kari += 10000000;
                imageTest.scorejudge = 1;
                a = true;
            }

            time += Time.deltaTime;
            if (time > 5 && !stage)
            {
                StageNum++;
                if (StageNum < 6)
                    SceneManager.LoadScene("Stage" + StageNum);//ここステージクリアしたら次のステージへ
                else
                    SceneManager.LoadScene("GameClearScene");

                time = 0;
                stage = true;
                //SceneManager.LoadScene("GameClearScene");
            }
        }
    }
}
