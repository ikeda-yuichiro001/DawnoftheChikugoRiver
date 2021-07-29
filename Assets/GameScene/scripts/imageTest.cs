using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class imageTest : MonoBehaviour
{
    // private Sprite image;
    public Sprite sozai_0, sozai_1, sozai_2, sozai_3, sozai_4, sozai_5, sozai_6, sozai_7, sozai_8, sozai_9;

    public Image s12, s11, s10, s9, s8, s7, s6, s5, s4, s3, s2, s1;
    public Image hs12, hs11, hs10, hs9, hs8, hs7, hs6, hs5, hs4, hs3, hs2, hs1;

    public Image[] numbers = new Image[10];
    public int[] scorenumber = new int[11];
    public static long kari;
    public static int scorejudge = 1;
    public static long hikari;
    public Sprite[] sprites = new Sprite[10];

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
        kari = 0;
        hikari = 1000000;           //10桁はできた
        for (int e = 0; e < 12; e++)
        {
            switch (e)
            {
                case 1:
                    scorenumber[0] = (int)((int)hikari % 10);
                    hs1.sprite = sprites[scorenumber[0]];
                    break;
                case 2:
                    scorenumber[1] = (int)((int)hikari / 10 % 10);
                    hs2.sprite = sprites[scorenumber[1]];
                    break;
                case 3:
                    scorenumber[2] = (int)((int)hikari / 100 % 10);
                    hs3.sprite = sprites[scorenumber[2]];
                    break;
                case 4:
                    scorenumber[3] = (int)((int)hikari / 1000 % 10);
                    hs4.sprite = sprites[scorenumber[3]];
                    break;
                case 5:
                    scorenumber[4] = (int)((int)hikari / 10000 % 10);
                    hs5.sprite = sprites[scorenumber[4]];
                    break;
                case 6:
                    scorenumber[5] = (int)((int)hikari / 100000 % 10);
                    hs6.sprite = sprites[scorenumber[5]];
                    break;
                case 7:
                    scorenumber[6] = (int)((int)hikari / 1000000 % 10);
                    hs7.sprite = sprites[scorenumber[6]];
                    break;
                case 8:
                    scorenumber[7] = (int)((int)hikari / 10000000 % 10);
                    hs8.sprite = sprites[scorenumber[7]];
                    break;
                case 9:
                    scorenumber[8] = (int)((int)hikari / 100000000 % 10);
                    hs9.sprite = sprites[scorenumber[8]];
                    break;
                case 10:
                    scorenumber[9] = (int)((int)hikari / 1000000000 % 10);
                    hs10.sprite = sprites[scorenumber[9]];
                    break;
                case 11:
                    scorenumber[10] = (int)((int)hikari / 10000000000 % 10);
                    hs11.sprite = sprites[scorenumber[10]];
                    break;
                case 12:
                    scorenumber[11] = (int)((int)hikari / 100000000000 % 10);
                    hs12.sprite = sprites[scorenumber[11]];
                    break;

            }
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

                //scorenumber[i] = (kari / (10 ^ i)) % 10;
                //スコア/1%10                                    スコアが動いた時の判断　scorejudge で判断する
                //スコア/10%10　                                  スコアのけた別で数字を取りその同じ数字を画像で表示する
                //スコア/100%10　　　　　　　　　　　　　　　　　スコアの桁数別の数字と数字の画像を同期させる
                //スコア/1000%10　
                //スコア/10000%10　　　　　　　　　　　　　　　　number[0～9] = スコア/10^?%10 
                //スコア/100000%10                               べき乗のやり方
                //スコア/1000000%10
                //スコア/100000000%10
                //スコア/1000000000%10         number[12] = SCRE / 1000000000000  %10 12桁のみ取り出せる
                //                             number[11] =      / 100000000000 %10
                switch (i)
                {
                    case 1:
                        scorenumber[0] = (int)((int)kari % 10);
                        s1.sprite = sprites[scorenumber[0]];
                        break;
                    case 2:
                        scorenumber[1] = (int)((int)kari / 10 % 10);
                        s2.sprite = sprites[scorenumber[1]];
                        break;
                    case 3:
                        scorenumber[2] = (int)((int)kari / 100 % 10);
                        s3.sprite = sprites[scorenumber[2]];
                        break;
                    case 4:
                        scorenumber[3] = (int)((int)kari / 1000 % 10);
                        s4.sprite = sprites[scorenumber[3]];
                        break;
                    case 5:
                        scorenumber[4] = (int)((int)kari / 10000 % 10);
                        s5.sprite = sprites[scorenumber[4]];
                        break;
                    case 6:
                        scorenumber[5] = (int)((int)kari / 100000 % 10);
                        s6.sprite = sprites[scorenumber[5]];
                        break;
                    case 7:
                        scorenumber[6] = (int)((int)kari / 1000000 % 10);
                        s7.sprite = sprites[scorenumber[6]];
                        break;
                    case 8:
                        scorenumber[7] = (int)((int)kari / 10000000 % 10);
                        s8.sprite = sprites[scorenumber[7]];
                        break;
                    case 9:
                        scorenumber[8] = (int)((int)kari / 100000000 % 10);
                        s9.sprite = sprites[scorenumber[8]];
                        break;
                    case 10:
                        scorenumber[9] = (int)((int)kari / 1000000000 % 10);
                        s10.sprite = sprites[scorenumber[9]];
                        break;
                    case 11:
                        scorenumber[10] = (int)((int)kari / 10000000000 % 10);
                        s11.sprite = sprites[scorenumber[10]];
                        break;
                    case 12:
                        scorenumber[11] = (int)((int)kari / 100000000000 % 10);
                        s12.sprite = sprites[scorenumber[11]];
                        break;
                }
                if (kari > hikari)
                {
                    hikari = kari;
                    for (int e = 0; e < 12; e++)
                    {
                        switch (e)
                        {
                            case 1:
                                scorenumber[0] = (int)((int)hikari % 10);
                                hs1.sprite = sprites[scorenumber[0]];
                                break;
                            case 2:
                                scorenumber[1] = (int)((int)hikari / 10 % 10);
                                hs2.sprite = sprites[scorenumber[1]];
                                break;
                            case 3:
                                scorenumber[2] = (int)((int)hikari / 100 % 10);
                                hs3.sprite = sprites[scorenumber[2]];
                                break;
                            case 4:
                                scorenumber[3] = (int)((int)hikari / 1000 % 10);
                                hs4.sprite = sprites[scorenumber[3]];
                                break;
                            case 5:
                                scorenumber[4] = (int)((int)hikari / 10000 % 10);
                                hs5.sprite = sprites[scorenumber[4]];
                                break;
                            case 6:
                                scorenumber[5] = (int)((int)hikari / 100000 % 10);
                                hs6.sprite = sprites[scorenumber[5]];
                                break;
                            case 7:
                                scorenumber[6] = (int)((int)hikari / 1000000 % 10);
                                hs7.sprite = sprites[scorenumber[6]];
                                break;
                            case 8:
                                scorenumber[7] = (int)((int)hikari / 10000000 % 10);
                                hs8.sprite = sprites[scorenumber[7]];
                                break;
                            case 9:
                                scorenumber[8] = (int)((int)hikari / 100000000 % 10);
                                hs9.sprite = sprites[scorenumber[8]];
                                break;
                            case 10:
                                scorenumber[9] = (int)((int)hikari / 1000000000 % 10);
                                hs10.sprite = sprites[scorenumber[9]];
                                break;
                            case 11:
                                scorenumber[10] = (int)((int)hikari / 10000000000 % 10);
                                hs11.sprite = sprites[scorenumber[10]];
                                break;
                            case 12:
                                scorenumber[11] = (int)((int)hikari / 100000000000 % 10);
                                hs12.sprite = sprites[scorenumber[11]];
                                break;

                        }
                    }
                }

                scorejudge = 0; //ほんとはゼロ
            }
        }
    }
}
