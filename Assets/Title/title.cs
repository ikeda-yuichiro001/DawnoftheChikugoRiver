using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    int point = 0;
    // Textコンポーネントを取得
    Image Tutorial;
    Image GameStart;
    Image Collection;
    Image Option;
    Image Quit;
    public float uptime, downtime;
    [Range(0.1f, 1.0f)]
    public float cnt;

    // Start is called before the first frame update
    void Start()
    {
        Tutorial = GameObject.Find("Canvas/Tutorial").GetComponent<Image>();
        GameStart = GameObject.Find("Canvas/GameStart").GetComponent<Image>();
        Collection = GameObject.Find("Canvas/Collection").GetComponent<Image>();
        Option = GameObject.Find("Canvas/Option").GetComponent<Image>();
        Quit = GameObject.Find("Canvas/Quit").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //上下にカーソル移動 --------------------------------
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            point++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            point--;
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
        if (point >= 4)
        {
            point = -1;
        }
        if (point <= -2)
        {
            point = 3;
        }

        if (Input.GetKeyDown(KeyCode.Escape)) point = 3;

        //選ばれたカーソルの色を変更＋それぞれの処理------------------------------

        if (point == -1)
        {
            Tutorial.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Tutorial.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        if (point == 0)
        {
            GameStart.color = new Color(1, 1, 1, 1);
        }
        else
        {
            GameStart.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        if(point == 1)
        {
            Collection.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Collection.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        if (point == 2)
        {
            Option.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Option.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        if (point == 3)
        {
            Quit.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Quit.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
        {
            switch (point)
            {
                case -1:
                    SceneManager.LoadScene("Tutorial");
                    break;
                case 0:
                    SceneManager.LoadScene("Difficulty");
                    break;
                case 1:
                    SceneManager.LoadScene("PictureBook");
                    break;
                case 2:
                    SceneManager.LoadScene("Option");
                    break;
                default:
                    Application.Quit();
                    Debug.Log("quit");
                    break;
            }
        }
    }

    public static void esc()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
