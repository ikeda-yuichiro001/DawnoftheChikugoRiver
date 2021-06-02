using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionButton : MonoBehaviour
{


    //各定義
    Image Decision;
    Text Number;
    Text Number2;
    Text NumberUp;
    Text NumberDown;
    /*Text NumberUp2;
    Text NumberDown2;*/
    Text BGM;
    Text SE;
    Text Default;
    Text Quit;
    public int point = 0;
    /*public int number_point=0;
    public int number_point2 = 0;
    private int value;*/

    void Start()
    {
        Decision = GameObject.Find("Canvas/Panel/Decision").GetComponent<Image>();
        BGM = GameObject.Find("Canvas/Panel/Decision/BGM").GetComponent<Text>();
        SE = GameObject.Find("Canvas/Panel/Decision/SE").GetComponent<Text>();
        Default = GameObject.Find("Canvas/Panel/Decision/Default").GetComponent<Text>();
        Quit = GameObject.Find("Canvas/Panel/Decision/Quit").GetComponent<Text>();
        Number = GameObject.Find("Canvas/Panel/Decision/Number").GetComponent<Text>();
        Number2 = GameObject.Find("Canvas/Panel/Decision/Number2").GetComponent<Text>();
        NumberUp = GameObject.Find("Canvas/Panel/Decision/NumberUp").GetComponent<Text>();
        NumberDown = GameObject.Find("Canvas/Panel/Decision/NumberDown").GetComponent<Text>();
        /*NumberUp2 = GameObject.Find("Canvas/Panel/Decision/NumberUp2").GetComponent<Text>();
        NumberDown2 = GameObject.Find("Canvas/Panel/Decision/NumberDown2").GetComponent<Text>();*/
    }

    //サウンド設定Buttonの色変化と決定キーを押したときの処理
    void Update()
    {


        //BGM等の画面の処理
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
            point = 1;
        }


        if (point == 0)
        {
            BGM.color = Color.red;
        }
        else
        {
            BGM.color = new Color32(70, 70, 70, 100);
        }


        if (point == 1)
        {
            SE.color = Color.red;
        }
        else
        {
            SE.color = new Color32(70, 70, 70, 100);
        }


        if (point == 2)
        {
            Default.color = Color.red;
        }
        else
        {
            Default.color = new Color32(70, 70, 70, 100);
        }


        if (point == 3)
        {
            Quit.color = Color.red;
        }
        else
        {
            Quit.color = new Color32(70, 70, 70, 100);
        }

        if(point==4)
        {
            Decision.color = Color.red;
        }
        else
        {
            Decision.color = new Color32(70, 70, 70, 100);
        }


        if (Input.GetKeyDown(KeyCode.Z))
        {
        }


        //決定Buttonを押したらタイトル画面へ
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (point == 4)
            {
                SceneManager.LoadScene("Title");
            }

        }
    }
}


public class Option
{
    static int bgm;
    public static int BGM
    {
        get
        {
            return bgm;
        }
        set
        {
            if (value > 100) bgm = 100;
            else if (value < 0) bgm = 0;
            else bgm = value;
        }
    }

    static int se;
    public static int SE
    {
        get
        {
            return se;
        }
        set
        {
            if (value > 100) se = 100;
            else if (value < 0) se = 0;
            else se = value;
        }
    }
}
