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
    public bool kill ;
    Text[] Text = new Text[50];
    public int[] y;
    public int point = 0,a = 0,h = 30;
    public int i,k;
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
        Panel_pos.y = Fish[0].gameObject.GetComponent<RectTransform>().position.y;
        Panel_pos.x = Fish[0].gameObject.GetComponent<RectTransform>().position.x;
    }

    void Update()
    {
        //矢印キーで動かす処理
        if (Input.GetKeyDown(KeyCode.UpArrow)) { point--; }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { point++;}
        if (Input.GetKeyDown(KeyCode.LeftArrow)) point = 50;
        if (Input.GetKeyDown(KeyCode.RightArrow)) point = 50;
        //1～50体と戻るボタンを上下でループさせる処理
        
        y = new int[8];
        for (int r = 0; r < 8; r++)
        {
            y[r] = point + r;
            if (y[r] > 49) y[r] -= 50;
            else if (y[r] < 0) y[r] += 50;
        }
        for (int r = 0; r < 8; r++)
            Fish[y[r]].gameObject.GetComponent<RectTransform>().position
               = new Vector3(Panel_pos.x, Panel_pos.y - h * r, 0);
            
            //1～50体の色
            for (i = 0; i < Fish.Length; i++)
            {
                Fish[i].enabled = false; 
                Text[i].enabled = false;
            }


            for (i = 0; i < 8; i++)
            { 
                Fish[y[i]].enabled = true;
                Text[y[i]].enabled = true;

            }
        if (point == Fish.Length) Fish[i].color = Color.green;
        else Fish[i].color = Color.white;
        Debug.Log(point);

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
