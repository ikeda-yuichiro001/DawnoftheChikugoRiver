using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneContollor : MonoBehaviour
{
    Image BackButton;
    
    public int point = 0;
    public int point2 = 0;

    void Start()
    {
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
