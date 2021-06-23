using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneContollor : MonoBehaviour
{
    Image BackButton;
    Image Fish1;  Image Fish2;  Image Fish3;  Image Fish4;  Image Fish5;
    Image Fish6;  Image Fish7;  Image Fish8;  Image Fish9;  Image Fish10;
    Image Fish11; Image Fish12; Image Fish13; Image Fish14; Image Fish15;
    Image Fish16; Image Fish17; Image Fish18; Image Fish19; Image Fish20;
    Image Fish21; Image Fish22; Image Fish23; Image Fish24; Image Fish25;
    Image Fish26; Image Fish27; Image Fish28; Image Fish29; Image Fish30;
    Image Fish31; Image Fish32; Image Fish33; Image Fish34; Image Fish35;
    Image Fish36; Image Fish37; Image Fish38; Image Fish39; Image Fish40;
    Image Fish41; Image Fish42; Image Fish43; Image Fish44; Image Fish45;
    Image Fish46; Image Fish47; Image Fish48; Image Fish49; Image Fish50;

    public int point = 0;
    public int point2 = 0;
    public int a = 0;
    public float h = 30;

    private Vector2 Panel_pos;

    void Start()
    {
        /*Fish = GameObject.Find("Canvas/Panel/Fish").GetComponent<Image>();*/
        Fish1 = GameObject.Find("Canvas/Panel/Fish1").GetComponent<Image>();
        Fish2 = GameObject.Find("Canvas/Panel/Fish2").GetComponent<Image>();
        Fish3 = GameObject.Find("Canvas/Panel/Fish3").GetComponent<Image>();
        Fish4 = GameObject.Find("Canvas/Panel/Fish4").GetComponent<Image>();
        Fish5 = GameObject.Find("Canvas/Panel/Fish5").GetComponent<Image>();
        Fish6 = GameObject.Find("Canvas/Panel/Fish6").GetComponent<Image>();
        Fish7 = GameObject.Find("Canvas/Panel/Fish7").GetComponent<Image>();
        Fish8 = GameObject.Find("Canvas/Panel/Fish8").GetComponent<Image>();
        Fish9 = GameObject.Find("Canvas/Panel/Fish9").GetComponent<Image>();
        Fish10 = GameObject.Find("Canvas/Panel/Fish10").GetComponent<Image>();
        Fish11 = GameObject.Find("Canvas/Panel/Fish11").GetComponent<Image>();
        Fish12 = GameObject.Find("Canvas/Panel/Fish12").GetComponent<Image>();
        Fish13 = GameObject.Find("Canvas/Panel/Fish13").GetComponent<Image>();
        Fish14 = GameObject.Find("Canvas/Panel/Fish14").GetComponent<Image>();
        Fish15 = GameObject.Find("Canvas/Panel/Fish15").GetComponent<Image>();
        Fish16 = GameObject.Find("Canvas/Panel/Fish16").GetComponent<Image>();
        Fish17 = GameObject.Find("Canvas/Panel/Fish17").GetComponent<Image>();
        Fish18 = GameObject.Find("Canvas/Panel/Fish18").GetComponent<Image>();
        Fish19 = GameObject.Find("Canvas/Panel/Fish19").GetComponent<Image>();
        Fish20 = GameObject.Find("Canvas/Panel/Fish20").GetComponent<Image>();
        Fish21 = GameObject.Find("Canvas/Panel/Fish21").GetComponent<Image>();
        Fish22 = GameObject.Find("Canvas/Panel/Fish22").GetComponent<Image>();
        Fish23 = GameObject.Find("Canvas/Panel/Fish23").GetComponent<Image>();
        Fish24 = GameObject.Find("Canvas/Panel/Fish24").GetComponent<Image>();
        Fish25 = GameObject.Find("Canvas/Panel/Fish25").GetComponent<Image>();
        Fish26 = GameObject.Find("Canvas/Panel/Fish26").GetComponent<Image>();


        
        BackButton = GameObject.Find("Canvas/BackButton").GetComponent<Image>();
    }

    void Update()
    {
        //矢印キーで動かす処理
        if (Input.GetKeyDown(KeyCode.UpArrow))point--;
        if (Input.GetKeyDown(KeyCode.DownArrow))point++;
        if (Input.GetKeyDown(KeyCode.LeftArrow))point2--;
        if (Input.GetKeyDown(KeyCode.RightArrow))point2++;
        //1～45体と戻るボタンを上下でループさせる処理
        if (point == 52)point = 0;
        if (point == -1)point = 51;
        //左右で"戻るボタン"に飛ぶ処理
        if (point2 == 1)
        {
            point = 51;
            point2--;
        }
        if (point2 == -1)
        {
            point = 51;
            point2++;
        }
        //スクロール

        //1～45体の色
        if (point == 0)
        {
            Fish1.color = Color.green;
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                
            }
        }
        else Fish1.color = Color.white;

        if (point == 1)
        {
            Fish2.color = Color.green;
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {

            }
        }
        else Fish2.color = Color.white;

        if (point == 2)
        {
            Fish3.color = Color.green;
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {

            }
        }
        else Fish3.color = Color.white;

        if (point == 3)
        {
            Fish4.color = Color.green;
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {

            }
        }
        else Fish4.color = Color.white;
        //戻るボタンの色の処理
        //戻るボタンを選択したときタイトルに戻る処理
        if (point == 51)
        {
            BackButton.color = Color.red;
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                SceneManager.LoadScene("title");
            }
        }
        else BackButton.color = Color.white;
    }
}
