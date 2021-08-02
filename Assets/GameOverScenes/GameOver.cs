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
    // Start is called before the first frame update
    void Start()
    {
        //RetryButton = GameObject.Find("Canvas/RetryButton").GetComponent<Image>();
        //TitleButton = GameObject.Find("Canvas/TitleButton").GetComponent<Image>();
        //Invoke("ChangeScene", 1.5f);
        ScoreMangers.herl = RetryRemain;
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
            RetryButton.color = new Color(255, 255, 255, 255);
            TitleButton.color = new Color(255, 255, 255, 0);
        }
        else
        {
            RetryButton.color = new Color(255, 255, 255, 0);
            TitleButton.color = new Color(255, 255, 255, 255);
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
     
            if(count == 0 )
            {
                RetryRemain--;
                SceneManager.LoadScene("Stage1");

            }
            else
            {
                SceneManager.LoadScene("Title");
            } 
        }
    }
}
