using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneContollor : MonoBehaviour
{
    Image Panel;
    RectTransform xxx;
    Image [] Fish = new Image[Max];
    public RawImage Picture;
    public Text FishName;
    public Text Syoukaibun;
    Text[] Text = new Text[Max];
    public static bool[] kill = new bool[Max];
    public int point;
    public int i;
    private Vector2 Panel_pos;
    const int Max = 16;
    public FishData[] DataBase;
    /* public int[] y;
    public int a = 0, h = 30, k, X;
    int Len = 15;
    public float Space;
    public float abc;
    public float aa,ac;*/
    public float uptime, downtime;
    [Range(0.1f, 1.0f)]
    public float cnt;
    void Start()
    {
        for (int t = 0; t < kill.Length; t++) { kill[t] = true; }
        for (int t = 0; t < Max; t++)
        {
            Fish[t] = GameObject.Find("Canvas/Fish" + t).GetComponent<Image>();
            Text[t] = GameObject.Find("Canvas/Fish"+ t +"/Text").GetComponent<Text>();
        }
        //Panel = GameObject.Find("Canvas/Panel").GetComponent<Image>();
        //xxx = GameObject.Find("Canvas/Panel").GetComponent<RectTransform>();
        for (int t = 0; t < Max - 1; t++)
        {
            if(kill[t] == true) 
            {
                Text[t].text = DataBase[t].name;
            }
            else
            {
                Text[t].text = "-------";
            }
        }
        Picture = GameObject.Find("Canvas/Picture").GetComponent<RawImage>();
        FishName = GameObject.Find("Canvas/FishName/FishName").GetComponent<Text>();
        Syoukaibun = GameObject.Find("Canvas/Syoukaibun/Syoukaibun").GetComponent<Text>();
    }

    void Update()
    {
        /*Panel_pos.y = Panel.gameObject.GetComponent<RectTransform>().position.y;
        Panel_pos.x = Panel.gameObject.GetComponent<RectTransform>().position.x;
        Space = Screen.height * abc;
        X = Screen.width;
        Debug.Log(Screen.width);
        Debug.Log(Screen.height);*/
        
        //矢印キーで動かす処理
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) { point--; }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) { point++; }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            uptime += Time.deltaTime;
            if (uptime > cnt) { point --; uptime = 0;}
            
        }
        else
        {
            uptime = 0;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            downtime += Time.deltaTime;
            if (downtime > cnt) { point++ ; downtime = 0; }

        }
        else
        {
            downtime = 0;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) point = Max - 1;
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) point = Max - 1;
        //1～50体と戻るボタンを上下でループさせる処理
        if(point >= Max) { point -= Max; }
        if (point < 0) { point += Max; }
        /*y = new int[Len];
        for (int r = 0; r < Len; r++)
        {
            y[r] = point + r;
            if (y[r] > Max - 1) y[r] -= Max;
            else if (y[r] < 0) y[r] += Max;
        }
        for (int r = 0; r < Len; r++)
            Fish[y[r]].gameObject.GetComponent<RectTransform>().position
               = new Vector3(Panel_pos.x , Panel_pos.y + X / ac - Space * r, 0);
            
            for (i = 0; i < Max; i++)
            {
                Fish[i].enabled = false; 
                Text[i].enabled = false;
            }


            for (i = 0; i < Len; i++)
            { 
                Fish[y[i]].enabled = true;
                Text[y[i]].enabled = true;
            }*/

        for (i = 0; i < Max; i++)
        {
            Fish[i].color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        Fish[point].color = Color.white;
        Debug.Log(point);
        if(point < Max-1)
        {
             if (kill[point] == true)
             {
                Syoukaibun.text = DataBase[point].discription;
                FishName.text = DataBase[point].name;
                Picture.texture = DataBase[point].image;
                Picture.color = Color.white;
             }
             else
             {
                Syoukaibun.text = "---------------";
                FishName.text = "-------";
                Picture.color = new Color(0, 0, 0, 0);
             }

        }
        else
        {
            Syoukaibun.text = "---------------";
            FishName.text = "-------";
            Picture.color = new Color(0, 0, 0, 0);
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return)
                || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
            {
                SceneManager.LoadScene("Title");
            }
        }
        
    }
}
[System.Serializable]
public class FishData
{
    public Texture2D image;
    public string name;
    [Multiline(7)]
    public string discription;
}