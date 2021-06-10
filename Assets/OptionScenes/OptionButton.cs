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
    public  int point = 0;
    /*AudioSource bgm;
    AudioSource se;*/

    void Start()
    {
        Decision = GameObject.Find("Canvas/Panel/Decision").GetComponent<Image>();
        BGM = GameObject.Find("Canvas/Panel/Decision/BGM").GetComponent<Text>();
        SE = GameObject.Find("Canvas/Panel/Decision/SE").GetComponent<Text>();
        Default = GameObject.Find("Canvas/Panel/Decision/Default").GetComponent<Text>();
        Number = GameObject.Find("Canvas/Panel/Decision/Number").GetComponent<Text>();
        Number2 = GameObject.Find("Canvas/Panel/Decision/Number2").GetComponent<Text>();
        
        /*bgm = GameObject.Find("BGMvolume").GetComponent<AudioSource>();
        se = GameObject.Find("SEvolume").GetComponent<AudioSource>();*/
    }

    //サウンド設定Buttonの色変化と決定キーを押したときの処理
    void Update()
    {
        Number.text = ((int)(Option.BGM * 100)).ToString("000");
        Number2.text = ((int)(Option.SE * 100)).ToString("000");

        //BGM等の画面の処理
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            point--;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            point++;
        }

        if (point == 4)
        {
            point = 0;
        }

        if (point == -1)
        {
            point = 3;
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

        if(point == 3)
        {
            Decision.color = Color.red;
        }
        else
        {
            Decision.color = new Color32(70, 70, 70, 100);
        }


        //決定Buttonを押したらタイトル画面へ
        if (point == 3)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("Title");

            }
        }
        

        //BGMのText数字増減
        if (point == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Option.BGM += 0.1f;
                Debug.Log(Option.BGM);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Option.BGM -= 0.1f;
                Debug.Log(Option.BGM);

            }
        }

        //if (Option.BGM < 0.0f) Option.BGM = 0.0f;
        //if (Option.BGM > 100.0f) Option.BGM = 100.0f;


        //SEのText数字増減
        if (point == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Option.SE += 0.1f;
                Debug.Log(Option.SE);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Option.SE -= 0.1f;
                Debug.Log(Option.SE);
            }
        }

        //if (Option.SE < 0.0f) Option.SE = 0.0f;
        //if (Option.SE > 100.0f) Option.SE = 100.0f;
        

        //Defalutの処理
        if(point == 2 && Input.GetKeyDown(KeyCode.Z))
        {
            Option.BGM = 0.1f;
            Option.SE = 0.1f;
            Debug.Log(Option.BGM);
            Debug.Log(Option.SE);
        }

        

        //BGMのvolume調整
        /*if (point == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                bgm.volume += 0.01f;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                bgm.volume -= 0.01f;
            }
        }

        if (point == 2 && Input.GetKeyDown(KeyCode.Z))
        {
            bgm.volume = 0.50f;
        }


        //SEのvolume調整
        if (point == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                se.volume += 0.01f;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                se.volume -= 0.01f;
            }
        }

        if (point == 2 && Input.GetKeyDown(KeyCode.Z))
        {
            se.volume = 0.50f;
        }*/
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
            if (value > 1) bgm = 1;
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
            if (value > 1) se = 1;
            else if (value < 0) se = 0;
            else se = value;
        }
    }
}



