using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    GameObject stage1boss;
    float time = 0;
    bool a = false;
    //bool down = false;
    // Start is called before the first frame update
    void Start()
    {
        stage1boss = GameObject.Find("kurumeusu");
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
            if (time > 5)
            {
                SceneManager.LoadScene("Stage1");//ここステージクリアしたら次のステージへ
                //SceneManager.LoadScene("GameClearScene");
            }
        }
    }
}
