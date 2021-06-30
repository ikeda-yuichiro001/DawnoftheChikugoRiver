using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneContollor : MonoBehaviour
{
    Image BackButton;
    Image Panel;
    RectTransform xxx;
    Image [] Fish = new Image[50];
    public bool[] kill = new bool[50];
    Text[] Text = new Text[50];
    
    public float point = 0,point2 = 0,a = 0,h = 30;
    public int i;
    private Vector2 Panel_pos;
    void Start()
    {
        for (int t = 0; t < Fish.Length; t++)
        {
            Fish[t] = GameObject.Find("Canvas/Panel/Fish" + t).GetComponent<Image>();
            Text[t] = GameObject.Find("Canvas/Panel/Fish"+ t +"/Text").GetComponent<Text>();
        }
        Panel = GameObject.Find("Canvas/Panel").GetComponent<Image>();
        xxx = GameObject.Find("Canvas/Panel").GetComponent<RectTransform>();
        BackButton = GameObject.Find("Canvas/BackButton").GetComponent<Image>();
        
    }

    void Update()
    {
        //矢印キーで動かす処理
        if (Input.GetKeyDown(KeyCode.UpArrow)) { point--; Panel_pos.y = a - h; xxx.position += new Vector3(0, Panel_pos.y, 0); }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { point++; Panel_pos.y = a + h; xxx.position += new Vector3(0, Panel_pos.y, 0); }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) point2--;
        if (Input.GetKeyDown(KeyCode.RightArrow)) point2++;
        //1～50体と戻るボタンを上下でループさせる処理
        if (point == 51){ point = 0;  xxx.position = new Vector2(xxx.position.x, 125); }
        if (point == -1){ point = 50; xxx.position = new Vector2(xxx.position.x, 1410); }
        //左右で"戻るボタン"に飛ぶ処理
        if (point2 == 1){point = 50;point2--;}
        if (point2 == -1){point = 50;point2++;}
        //スクロール
        //1～50体の色
        for (i = 0; i < Fish.Length; i++)
        {
            if (point == i)Fish[i].color = Color.green;
            else Fish[i].color = Color.white;
            Fish[i].enabled = point <= i && i <= point + 7;
            Text[i].enabled = point <= i && i <= point + 7;
            if(kill[i] == true)
            {

            }
        }
        //戻るボタンの色の処理と選択したときタイトルに戻る処理
        if (point == 50)
        {
            BackButton.color = Color.red;
            if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("title");
            }
        }
        else BackButton.color = Color.white;
    }
}
