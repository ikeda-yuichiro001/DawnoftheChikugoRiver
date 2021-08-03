using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionButton : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod()]
    static void Init()
    {
        Option.BGM = PlayerPrefs.GetFloat("Option.BGM",0.9f );
        Option.SE = PlayerPrefs.GetFloat("Option.SE",0.9f);
        //Debug.Log("Initialized");
    }

    //各定義
    Image Decision;
    Text Number;
    Text Number2;
    Image BGM;
    Image SE;
    Image Default;
    public  int point = 0;

    //定義したやつの取得
    void Start()
    {
        Decision = GameObject.Find("Canvas/Decision").GetComponent<Image>();
        BGM = GameObject.Find("Canvas/BGM").GetComponent<Image>();
        SE = GameObject.Find("Canvas/SE").GetComponent<Image>();
        Default = GameObject.Find("Canvas/Default").GetComponent<Image>();
        Number = GameObject.Find("Canvas/Number").GetComponent<Text>();
        Number2 = GameObject.Find("Canvas/Number2").GetComponent<Text>();
        
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
            BGM.color = Color.white;
        }
        else
        {
            BGM.color = new Color32(207, 207, 207, 255);
        }


        if (point == 1)
        {
            SE.color = Color.white;
        }
        else
        {
            SE.color = new Color32(207, 207, 207, 255);
        }


        if (point == 2)
        {
            Default.color = Color.white;
        }
        else
        {
            Default.color = new Color32(207, 207, 207, 255);
        }

        if (point == 3)
        {
            Decision.color = Color.white;
        }
        else
        {
            Decision.color = new Color32(207, 207, 207, 255);
        }

        

        //決定Buttonを押したらタイトル画面へ
        if (point == 3)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                    //dataの保存
                    PlayerPrefs.SetFloat("Option.BGM", Option.BGM);
                    PlayerPrefs.SetFloat("Option.SE", Option.SE);
                    PlayerPrefs.Save();
                    Debug.Log("BGMとSEは保存された");
                    
                    SceneManager.LoadScene("Title");

            }
        }


        //BGMのText数字増減
        if (point == 0)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Option.BGM += 0.001f;
               
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Option.BGM -= 0.001f;
               

            }
        }


        //SEのText数字増減
        if (point == 1)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Option.SE += 0.001f;
                
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Option.SE -= 0.001f;
                
            }
        }


        //Defalutの処理
        if (point == 2 && Input.GetKeyDown(KeyCode.Z))
        {
            Option.BGM = 0.1f;
            Option.SE = 0.1f;
        }

        
        Number.text = ((int)(Option.BGM * 100)).ToString("000");

        Number2.text = ((int)(Option.SE * 100)).ToString("000");
    }
}


//BGMとSEの数字格納庫
public class Option
{
    //bgmが呼ばれたらgetへ行く　BGMが呼ばれたらsetへ行く
    static float bgm = 0.9f;
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
    static float se = 0.9f;
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
