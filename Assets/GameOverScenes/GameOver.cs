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
            
            RetryButton.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            TitleButton.color = new Color(0.6f, 0.6f, 0.6f, 1f);
        }
        else
        {
            
            TitleButton.color = new Color(1, 1,1,1);
            RetryButton.color = new Color(0.6f, 0.6f, 0.6f, 1);
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
                ChangeScene();
                //title
            }
                
        }

       
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("Title");
    }
}
