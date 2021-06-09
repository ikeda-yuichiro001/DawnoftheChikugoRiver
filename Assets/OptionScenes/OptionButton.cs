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
    Text BGM;
    Text SE;
    Text Default;
    Text Quit;
    public static int point = 0;
   // public static int point2 = 0;
    public Text Textbgmvol;
    protected float bgmvol;
    public Text Textsevol;
    protected float sevol;

    void Start()
    {
        bgmvol = 0;
        sevol = 0;
        Decision = GameObject.Find("Canvas/Panel/Decision").GetComponent<Image>();
        BGM = GameObject.Find("Canvas/Panel/Decision/BGM").GetComponent<Text>();
        SE = GameObject.Find("Canvas/Panel/Decision/SE").GetComponent<Text>();
        Default = GameObject.Find("Canvas/Panel/Decision/Default").GetComponent<Text>();
        Quit = GameObject.Find("Canvas/Panel/Decision/Quit").GetComponent<Text>();
        Number = GameObject.Find("Canvas/Panel/Decision/Number").GetComponent<Text>();
        Number2 = GameObject.Find("Canvas/Panel/Decision/Number2").GetComponent<Text>();
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
            point = 4;
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

        //BGM・SEvol用のText移動
        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            point2--;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            point2++;
        }

        if(point2 == 2)
        {
            point2 = 0;
        }

        if(point2 == -1)
        {
            point2 = 1;
        }

        if (point2 == 0)
        {
            BGM.color = Color.red;
        }
        else
        {
            BGM.color = new Color32(70, 70, 70, 100);
        }


        if (point2 == 1)
        {
            SE.color = Color.red;
        }
        else
        {
            SE.color = new Color32(70, 70, 70, 100);
        }*/


        //決定Buttonを押したらタイトル画面へ
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (point == 4)
            {
                SceneManager.LoadScene("Title");
            }

        }

        //BGM音量増減
        Textbgmvol.text = string.Format("vol {0:000} ",bgmvol);
         if (point == 0 && Input.GetKeyDown(KeyCode.RightArrow))
         {
            bgmvol++;
         }

        if (point == 0 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            bgmvol--;
        }

        if (bgmvol < 0) bgmvol = 0;
        if (bgmvol > 100) bgmvol = 100;


        //SE音量増減
        Textsevol.text = string.Format("vol {0:000} ", sevol);
        if (point == 1 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            sevol++;
        }

        if (point == 1 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sevol--;
        }

        if (sevol < 0) sevol = 0;
        if (sevol > 100) sevol = 100;
        


        //Defalutの処理
        if(point == 2 && Input.GetKeyDown(KeyCode.Z))
        {
            bgmvol = 50;
            sevol = 50;
        }
    }
}


//BGMとSEの数字格納庫
public class Option
{
    //bgmが呼ばれたらgetへ行く　BGMが呼ばれたらsetへ行く
    static float bgm;
    public static float BGM
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

    //seが呼ばれたらgetへ行く　SEが呼ばれたらsetへ行く
    static float se;
    public static float SE
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



