using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenechange : MovieScene
{
    public float speed = 0.005f;
    float alfa = 0;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += UnityEngine.Time.deltaTime;
        Debug.Log(time);
        if (time >= 10)
        {
            GetComponent<Image>().color = new Color(0, 0, 0, alfa);
            alfa += speed;
            if (alfa >= 1)
            {
                SceneManager.LoadScene("StageScene_" + StageManager.stage);
            }
            Debug.Log(alfa);
        }
    }
}
