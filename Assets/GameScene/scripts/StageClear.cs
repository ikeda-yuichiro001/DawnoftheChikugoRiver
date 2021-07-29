using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    GameObject stage1boss;
    float time = 0;
    //bool down = false;
    // Start is called before the first frame update
    void Start()
    {
        stage1boss = GameObject.Find("enemy3");
    }

    // Update is called once per frame
    void Update()
    {
        if ( stage1boss == null)
        {

            time += UnityEngine.Time.deltaTime;
            if (time > 1)
                SceneManager.LoadScene("GameClear");
        }
    }
}
