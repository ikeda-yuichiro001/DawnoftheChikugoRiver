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
            Debug.Log("aaaaa");

            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
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

            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (point2 == 0)
                {
                    GameLevel.Level = point;
                    SceneManager.LoadScene("Stage1");
                }
                else
                {
                    window.SetActive(false);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                point--;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                point++;
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


            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("bbbbb");
                if (point == 4)
                {
                    imageTest.ScoreReset();
                    SceneManager.LoadScene("Title");
                }
                else
                {
                    window.SetActive(true);
                    Debug.Log("cccc");
                }
            }
        }
    }
}


