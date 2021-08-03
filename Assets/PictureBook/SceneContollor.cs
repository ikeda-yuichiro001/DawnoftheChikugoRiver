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
    public static bool[] kill = new bool[50];
    public int[] y;
    public int point = 0,a = 0,h = 30;
    public int i,k;
    private Vector2 Panel_pos;
    const int Max = 51;
    int Len = 15;
    public float Space;
    public FishData[] DataBase;
    public float abc;
    public float aa;
    void Start()
    {
        for (int t = 0; t < kill.Length; t++) { kill[t] = true; }
        for (int t = 0; t < Max; t++)
        {
            Fish[t] = GameObject.Find("Canvas/Panel/Fish" + t).GetComponent<Image>();
            Text[t] = GameObject.Find("Canvas/Panel/Fish"+ t +"/Text").GetComponent<Text>();
        }
        Panel = GameObject.Find("Canvas/Panel").GetComponent<Image>();
        xxx = GameObject.Find("Canvas/Panel").GetComponent<RectTransform>();
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
        Panel_pos.y = Panel.gameObject.GetComponent<RectTransform>().position.y;
        Panel_pos.x = Panel.gameObject.GetComponent<RectTransform>().position.x;
        Space = Screen.height * abc;
        Debug.Log(Screen.height);
        //矢印キーで動かす処理
        if (Input.GetKeyDown(KeyCode.UpArrow)) { point--; }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { point++;}
        if (Input.GetKeyDown(KeyCode.LeftArrow)) point = Max - 1;
        if (Input.GetKeyDown(KeyCode.RightArrow)) point = Max - 1;
        //1～50体と戻るボタンを上下でループさせる処理
        if(point >= Max) { point -= Max; }
        if (point < 0) { point += Max; }
        y = new int[Len];
        for (int r = 0; r < Len; r++)
        {
            y[r] = point + r;
            if (y[r] > Max - 1) y[r] -= Max;
            else if (y[r] < 0) y[r] += Max;
        }
        for (int r = 0; r < Len; r++)
            Fish[y[r]].gameObject.GetComponent<RectTransform>().position
               = new Vector3(Panel_pos.x, Panel_pos.y + aa - Space * r, 0);
            
            //1～50体の色
            for (i = 0; i < Max; i++)
            {
                Fish[i].enabled = false; 
                Text[i].enabled = false;
            }


            for (i = 0; i < Len; i++)
            { 
                Fish[y[i]].enabled = true;
                Text[y[i]].enabled = true;
            }

        for (i = 0; i < Max; i++)
        {
            Fish[i].color = new Color32(100, 100, 100, 100);
        }
        Fish[point].color = Color.white;
        Debug.Log(point);
        if(point < 50)
        {
             if (kill[point] == true)
             {
                Syoukaibun.text = DataBase[point].discription;
                FishName.text = DataBase[point].name;
                Picture.texture = DataBase[point].image;
             }
             else
             {
                Syoukaibun.text = "---------------";
                FishName.text = "-------";
                Picture.texture = null;
             }

        }
        else
        {
            Syoukaibun.text = "---------------";
            FishName.text = "-------";
            Picture.texture = null;
            if (Input.GetKeyDown(KeyCode.Z))
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