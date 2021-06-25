using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneContollor : MonoBehaviour
{
    Image BackButton;
    Image Panel;
    Image [] Fish = new Image[50];


    public float point = 0,point2 = 0,a = 0,h = 30,p;
    private Vector3 Panel_pos;

    void Start()
    {
            Fish[0] = GameObject.Find("Canvas/Panel/Fish1").GetComponent<Image>();
            Fish[1] = GameObject.Find("Canvas/Panel/Fish2").GetComponent<Image>();
            Fish[2] = GameObject.Find("Canvas/Panel/Fish3").GetComponent<Image>();
            Fish[3] = GameObject.Find("Canvas/Panel/Fish4").GetComponent<Image>();
            Fish[4] = GameObject.Find("Canvas/Panel/Fish5").GetComponent<Image>();
            Fish[5] = GameObject.Find("Canvas/Panel/Fish6").GetComponent<Image>();
            Fish[6] = GameObject.Find("Canvas/Panel/Fish7").GetComponent<Image>();
            Fish[7] = GameObject.Find("Canvas/Panel/Fish8").GetComponent<Image>();
            Fish[8] = GameObject.Find("Canvas/Panel/Fish9").GetComponent<Image>();
            Fish[9] = GameObject.Find("Canvas/Panel/Fish10").GetComponent<Image>();
            Fish[10] = GameObject.Find("Canvas/Panel/Fish11").GetComponent<Image>();
            Fish[11] = GameObject.Find("Canvas/Panel/Fish12").GetComponent<Image>();
            Fish[12] = GameObject.Find("Canvas/Panel/Fish13").GetComponent<Image>();
            Fish[13] = GameObject.Find("Canvas/Panel/Fish14").GetComponent<Image>();
            Fish[14] = GameObject.Find("Canvas/Panel/Fish15").GetComponent<Image>();
            Fish[15] = GameObject.Find("Canvas/Panel/Fish16").GetComponent<Image>();
            Fish[16] = GameObject.Find("Canvas/Panel/Fish17").GetComponent<Image>();


        Panel = GameObject.Find("Canvas/Panel").GetComponent<Image>();
        BackButton = GameObject.Find("Canvas/BackButton").GetComponent<Image>();
    }
    
    void Update()
    {
        //矢印キーで動かす処理
        if (Input.GetKeyDown(KeyCode.UpArrow)){point--;Panel_pos.y -= a - p * h;}
        if (Input.GetKeyDown(KeyCode.DownArrow)){point++;Panel_pos.y += a + p * h;}
        if (Input.GetKeyDown(KeyCode.LeftArrow))point2--;
        if (Input.GetKeyDown(KeyCode.RightArrow))point2++;
        //1～50体と戻るボタンを上下でループさせる処理
        if (point == 51)point = 0;
        if (point == -1)point = 50;
        //左右で"戻るボタン"に飛ぶ処理
        if (point2 == 1){point = 50;point2--;}
        if (point2 == -1){point = 50;point2++;}Debug.Log(Panel_pos);
        //スクロール

        //1～50体の色
        for (int i = 0; i <= 16; i++)//Fish.Length
        {
            if (point == i)Fish[i].color = Color.green;
            else Fish[i].color = Color.white;
        }
        //戻るボタンの色の処理
        //戻るボタンを選択したときタイトルに戻る処理
        if (point == 50)
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
