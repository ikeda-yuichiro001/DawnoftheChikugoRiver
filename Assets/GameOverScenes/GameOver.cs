using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public int count;
    public Image RetryButton;//+
    public Image TitleButton;//+
    public static int RetryRemain = 3;
    public static int MaxRetry = 3;
    // Start is called before the first frame update
    void Start()
    {
        //RetryButton = GameObject.Find("Canvas/RetryButton").GetComponent<Image>();
        //TitleButton = GameObject.Find("Canvas/TitleButton").GetComponent<Image>();
        //Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (RetryRemain > 0)
        {

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                count = 1 - count;
            }
        }
        else
        {
            count = 1;
        }


        if (count == 0)
        {
            RetryButton.color = new Color32(255, 255, 255, 255);
            TitleButton.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        else
        {
            RetryButton.color = new Color(0.5f, 0.5f, 0.5f, 1);
            TitleButton.color = new Color32(255, 255, 255, 255);
        }

        if(Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
        {
     
            if(count == 0 )
            {
                RetryRemain--;
                imageTest.kari = MaxRetry - RetryRemain;
                ScoreMangers.RetryRemain = 3;
                ScoreMangers.Boom = 3;
                ScoreMangers.Power = 8;
                ScoreMangers.herl = RetryRemain;
                SceneManager.LoadScene("Stage1");

            }
            else
            {
                RetryRemain = 3;
                ScoreMangers.herl = RetryRemain;
                ScoreMangers.RetryRemain = 3;
                ScoreMangers.Boom = 3;
                ScoreMangers.Power = 0;
                imageTest.kari = 0;
                SceneManager.LoadScene("Title");
            } 
        }
    }
}
