using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneContollor : MonoBehaviour
{
    Image BackButton;
    Button Fish1;
    Button Fish2;
    Image Fish3; 
    Image Fish4; 
    Image Fish5; 
    Image Fish6; 
    Image Fish7; 
    Image Fish8; 
    Image Fish9;
    /*
    Button Fish3;
    Button Fish4;
    Button Fish5;
    Button Fish6;
    Button Fish7;
    Button Fish8;
    Button Fish9;
               */
    
    public int point = 0;
    public int point2 = 0;
    int F7;
    // Start is called before the first frame update
    void Start()
    {
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

        
        /*if (CP != point)
            CP = point;

        for (int p = 0; p < 50; p++)
        {
            
        }
        ColorBlock white = default;
        ColorBlock green = default;
        //1～45体の魚の色の処理
        if (point == 0)Fish1.colors = green;
        else Fish1.colors = white;

        if (point == 1)Fish2.colors = green;
        else Fish2.colors = white;

        if (point == 2) Fish3.color = Color.green;
        else Fish3.color = Color.white;

        if (point == 3) Fish4.color = Color.green;
        else Fish4.color = Color.white;

        if (point == 4) Fish5.color = Color.green;
        else Fish5.color = Color.white;

        if (point == 5) Fish6.color = Color.green;
        else Fish6.color = Color.white;

        if (point == 6)
        {
            Fish7.color = Color.green;
            point = F7;
        }
        else Fish7.color = Color.white;

        if (point >= 0)

        //ロール
        if ( && point % 7 == 0) 
        {
             for (point  (point+7))
             {

             }Debug.Log(point);
        }*/

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
