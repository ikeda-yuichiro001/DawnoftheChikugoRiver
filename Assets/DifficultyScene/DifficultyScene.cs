using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DifficultyScene : MonoBehaviour
{
    Image Easy; 
    Image Normal; 
    Image Hard;
    Image VeryHard;
    Image Reset;
    Image Yes;
    Image No;
    public GameObject window;
    public int point = 0;
    public int point2 = 0;
    public static int difspd = 1;

    public float uptime, downtime;
    [Range(0.1f, 1.0f)]
    public float cnt;


    void Start()
    {
        Easy = GameObject.Find("Canvas/Easy").GetComponent<Image>();
        Normal = GameObject.Find("Canvas/Normal").GetComponent<Image>();
        Hard = GameObject.Find("Canvas/Hard").GetComponent<Image>();
        VeryHard = GameObject.Find("Canvas/VeryHard").GetComponent<Image>();
        Reset = GameObject.Find("Canvas/Reset").GetComponent<Image>();
        Yes = GameObject.Find("Canvas_window/Yes").GetComponent<Image>();
        No = GameObject.Find("Canvas_window/No").GetComponent<Image>();
        window = GameObject.Find("Canvas_window");
        window.SetActive(false);
        Debug.Log("debug comment");
    }

    
    void Update()
    {
        title.esc();

        if (window.activeSelf)
        {
            //Debug.Log("aaaaa");

            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)
                || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            {
                point2 = 1 - point2;
            }

            if (point2 == 0)
            {
                Yes.color = Color.white;
                No.color = new Color(0.5f, 0.5f, 0.5f, 1);
            }
            else
            {
                No.color = Color.white;
                Yes.color = new Color(0.5f, 0.5f, 0.5f, 1);
            }

            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
            {
                if (point2 == 0)
                {
                    GameLevel.Level = point;
                    StageManager.stage = 1;
                    GameOver.RetryRemain = 3;
                    ScoreMangers.herl = GameOver.RetryRemain;
                    ScoreMangers.RetryRemain = 3;
                    Debug.Log(ScoreMangers.RetryRemain);
                    imageTest.kari = 0;
                    SceneManager.LoadScene("Stage" + StageManager.stage);
                }
                else
                {
                    window.SetActive(false);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                point--;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                point++;
            }

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                uptime += Time.deltaTime;
                if (uptime > cnt) { point--; uptime = 0; }

            }
            else
            {
                uptime = 0;
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                downtime += Time.deltaTime;
                if (downtime > cnt) { point++; downtime = 0; }

            }
            else
            {
                downtime = 0;
            }
            if (point == 5)
            {
                point = 0;
            }
            if (point == -1)
            {
                point = 4;
            }


            if (point == 0)
            {
                Easy.color = Color.white;
                difspd = point + 1;
            }
            else
            {
                Easy.color = new Color(0.5f, 0.5f, 0.5f, 1);
            }


            if (point == 1)
            {
                Normal.color = Color.white;
                difspd = point + 1;
            }
            else
            {
                Normal.color = new Color(0.5f, 0.5f, 0.5f, 1);
            }


            if (point == 2)
            {
                Hard.color = Color.white;
                difspd = point + 1;
            }
            else
            {
                Hard.color = new Color(0.5f, 0.5f, 0.5f, 1);
            }


            if (point == 3)
            {
                VeryHard.color = Color.white;
                difspd = point + 1;
            }
            else
            {
                VeryHard.color = new Color(0.5f, 0.5f, 0.5f, 1);
            }


            if (point == 4)
            {
                Reset.color = Color.white;
            }
            else
            {
                Reset.color = new Color(0.5f, 0.5f, 0.5f, 1);
            }


            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return)
                || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
            {
                //Debug.Log("bbbbb");
                if (point == 4)
                {
                    imageTest.ScoreReset();
                    SceneManager.LoadScene("Title");
                }
                else
                {
                    window.SetActive(true);
                    //Debug.Log("cccc");
                }
            }
        }
    }
}


