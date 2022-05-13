using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionButton : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod()]
    public static void Init()
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
    public float uptime, downtime;
    [Range(0.1f, 1.0f)]
    public float cnt;

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
            BGM.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }


        if (point == 1)
        {
            SE.color = Color.white;
        }
        else
        {
            SE.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }


        if (point == 2)
        {
            Default.color = Color.white;
        }
        else
        {
            Default.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }

        if (point == 3)
        {
            Decision.color = Color.white;
        }
        else
        {
            Decision.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }

        

        //決定Buttonを押したらタイトル画面へ
        if (point == 3)
        {
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
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
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                Option.BGM += 0.001f;
               
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                Option.BGM -= 0.001f;
               

            }
        }


        //SEのText数字増減
        if (point == 1)
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                Option.SE += 0.001f;
                
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                Option.SE -= 0.001f;
                
            }
        }


        //Defalutの処理
        if (point == 2)
        {
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
            {
                Option.BGM = 0.1f;
                Option.SE = 0.1f;
            }
        }

        
        Number.text = ((int)(Option.BGM * 100)).ToString("000");

        Number2.text = ((int)(Option.SE * 100)).ToString("000");
        //aaaaaa
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
