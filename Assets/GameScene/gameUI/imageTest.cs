using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class imageTest : MonoBehaviour
{
    // private Sprite image;
    public Sprite sozai_0, sozai_1, sozai_2, sozai_3, sozai_4, sozai_5, sozai_6, sozai_7, sozai_8, sozai_9;

    public Image[] Imgs = new Image[12];// s12, s11, s10, s9, s8, s7, s6, s5, s4, s3, s2, s1;
    public Image[] HighScoreImages = new Image[12];// hs12, hs11, hs10, hs9, hs8, hs7, hs6, hs5, hs4, hs3, hs2, hs1;

    public Image[] numbers = new Image[10];
    public int[] scorenumber = new int[11];
    public static long kari = 0;
    public static int scorejudge = 1;
    public static long hikari = 1000000;
    public Sprite[] sprites = new Sprite[10];

    int ScoreExceed = 0;//extendボーダーの制御



    // オブジェクトの取得
    // GameObject image_object = GameObject.Find("Image");
    // コンポーネントの取得
    //Image image_component = image_object.GetComponent<Image>();

    // Start is called before the first frame update
    void Start()
    {
        //スコアの２桁目を取ってきてそれ
        //s12.sprite =
        //numbers i  = GetComponent<Image>();
        //緑波線出てるけど気にしない by 西村
        if (kari != 0)
            kari = kari;
        else
            kari = 0;

        if (hikari != 1000000)
            hikari = hikari;            //10桁はできた
        else
            hikari = 1000000;

        for (int e = 0; e < 12; e++)
        {
            HighScoreImages[e].sprite = sprites[(int)hikari / (int)Mathf.Pow(10, e) % 10];
        }
        scorejudge = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (/*scoreが増えたとき*/scorejudge == 1)  //1<? 範囲の時に作動するようにしたい
        {

            for (int i = 0; i < 12; i++)
            {
                Imgs[i].sprite = sprites[(int)kari / (int)Mathf.Pow(10, i) % 10];



                if (kari > hikari)
                {
                    hikari = kari;
                    for (int e = 0; e < 12; e++)
                    {
                        HighScoreImages[e].sprite = sprites[(int)hikari / (int)Mathf.Pow(10, e) % 10];
                    }

                }


                scorejudge = 0; //ほんとはゼロ
            }
        }
        if (kari >= 10000000 && ScoreExceed == 0)
        {
            playerInst.Zanki++;
            Debug.Log(playerInst.Zanki);
            ScoreExceed++;
            return;
        }
        if (kari >= 30000000 && ScoreExceed == 1)
        {
            playerInst.Zanki++;
            Debug.Log(playerInst.Zanki);
            ScoreExceed++;
            return;
        }
        if (kari >= 50000000 && ScoreExceed == 2)
        {
            playerInst.Zanki++;
            Debug.Log(playerInst.Zanki);
            ScoreExceed++;
            return;
        }
        if (kari >= 75000000 && ScoreExceed == 3)
        {
            playerInst.Zanki++;
            Debug.Log(playerInst.Zanki);
            ScoreExceed++;
            return;
        }
        if (kari >= 100000000 && ScoreExceed == 4)
        {
            playerInst.Zanki++;
            Debug.Log(playerInst.Zanki);
            ScoreExceed++;
            return;
        }
    }

    public static void ScoreReset()
    {
        kari = 0;
    }

}
