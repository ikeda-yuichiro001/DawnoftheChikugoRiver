using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    int point = 0;
    // Textコンポーネントを取得
    Text GameStart;
    Text Collection;
    Text Option;
    Text Quit;

    // Start is called before the first frame update
    void Start()
    {
        GameStart = GameObject.Find("Canvas/GameStart").GetComponent<Text>();
        Collection = GameObject.Find("Canvas/Collection").GetComponent<Text>();
        Option = GameObject.Find("Canvas/Option").GetComponent<Text>();
        Quit = GameObject.Find("Canvas/Quit").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //上下にカーソル移動 --------------------------------
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            point++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            point--;
        }
        if (point >= 4)
        {
            point =  0;
        }
        if (point <= -1)
        {
            point = 3;
        }

        //選ばれたカーソルの色を変更＋それぞれの処理------------------------------

        GameStart.color  = point == 0 ? new Color(1, 1, 1, 1) : new Color(0.5f, 0.5f, 0.5f, 1);
        Collection.color = point == 1 ? new Color(1, 1, 1, 1) : new Color(0.5f, 0.5f, 0.5f, 1);
        Option.color     = point == 2 ? new Color(1, 1, 1, 1) : new Color(0.5f, 0.5f, 0.5f, 1);
        Quit.color       = point == 3 ? new Color(1, 1, 1, 1) : new Color(0.5f, 0.5f, 0.5f, 1);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (point)
            {
                case 0:
                    SceneManager.LoadScene("DifficultySelect");
                    break;
                case 1:
                    SceneManager.LoadScene("CollectionScene");
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
}
