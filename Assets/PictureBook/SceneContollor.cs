using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneContollor : MonoBehaviour
{
    Image BackButton;
    Image Fish1;
    Image Fish2;
    Image Fish3;
    Image Fish4;
    Image Fish5;
    Image Fish6;
    Image Fish7;
    Image Fish8;
    Image Fish9;

    public int point = 0;
    public int point2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Fish1 = GameObject.Find("Canvas/Fish1").GetComponent<Image>();
        Fish2 = GameObject.Find("Canvas/Fish2").GetComponent<Image>();
        Fish3 = GameObject.Find("Canvas/Fish3").GetComponent<Image>();
        Fish4 = GameObject.Find("Canvas/Fish4").GetComponent<Image>();
        Fish5 = GameObject.Find("Canvas/Fish5").GetComponent<Image>();
        Fish6 = GameObject.Find("Canvas/Fish6").GetComponent<Image>();
        Fish7 = GameObject.Find("Canvas/Fish7").GetComponent<Image>();

        BackButton = GameObject.Find("Canvas/BackButton").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //矢印キーで動かす処理
        if (Input.GetKeyDown(KeyCode.UpArrow))point--;
        if (Input.GetKeyDown(KeyCode.DownArrow))point++;
        if (Input.GetKeyDown(KeyCode.LeftArrow))point2--;
        if (Input.GetKeyDown(KeyCode.RightArrow))point2++;
        //1～45体と戻るボタンを上下でループさせる処理
        if (point == 51)point = 0;
        if (point == -1)point = 50;
        //左右で戻るボタンに飛ぶ処理
        if (point2 == 1)
        {
            point = 50;
            point2--;
        }
        if (point2 == -1)
        {
            point = 50;
            point2++;
        }

        for (int p = 0; p < 50; p++)
        {
            
        }
        //1～45体の魚の色の処理
        if (point == 0) Fish1.color = Color.green;
        else Fish1.color = Color.white;

        if (point == 1) Fish2.color = Color.green;
        else Fish2.color = Color.white;

        if (point == 2) Fish3.color = Color.green;
        else Fish3.color = Color.white;

        if (point == 3) Fish4.color = Color.green;
        else Fish4.color = Color.white;

        if (point == 4) Fish5.color = Color.green;
        else Fish5.color = Color.white;

        if (point == 5) Fish6.color = Color.green;
        else Fish6.color = Color.white;

        if (point == 6) Fish7.color = Color.green;
        else Fish7.color = Color.white;

        if(point >= 0)

        //戻るボタンの色の処理
        if (point == 50)BackButton.color = Color.red;
        else BackButton.color = Color.white;
        //戻るボタンを選択したときタイトルに戻る処理
        if(point == 50)
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                SceneManager.LoadScene("title");
            }
        }
    }
}
