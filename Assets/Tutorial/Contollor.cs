using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contollor : MonoBehaviour
{
    public int point, Page, MaxPage, a;
    Image Left, Right, PreGame, Return;
    RawImage Gazou;
    Text page;
    public float uptime, downtime;
    public PageData[] DataBase;
    [Range(0.1f, 1.0f)]
    public float cnt;

    void Start()
    {
        Left = GameObject.Find("Canvas/Left").GetComponent<Image>();
        Right = GameObject.Find("Canvas/Right").GetComponent<Image>();
        PreGame = GameObject.Find("Canvas/preGame").GetComponent<Image>();
        Return = GameObject.Find("Canvas/Return").GetComponent<Image>();
        Gazou = GameObject.Find("Canvas/gazou").GetComponent<RawImage>();
        page = GameObject.Find("Canvas/Page").GetComponent<Text>();
        Page = 1;
        a = MaxPage - 1;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)  || Input.GetKeyDown(KeyCode.A)) point -- ;
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) point ++;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            uptime += Time.deltaTime;
            if (uptime > cnt) { point--; uptime = 0; }

        }
        else
        {
            uptime = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            downtime += Time.deltaTime;
            if (downtime > cnt) { point++; downtime = 0; }

        }
        else
        {
            downtime = 0;
        }
        if (point < 0) { point = 3; }if(point > 3) { point = 0; }
        if(Page < 1) { Page = a; }if(Page > a) { Page = 1;}
        if (point == 0)
        {
            Left.color = new Color(1, 1, 1, 1);
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
            {
                Page--;
            }
        }
        else
        {
            Left.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        if (point == 1)
        {
            Right.color = new Color(1, 1, 1, 1);
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
            {
                Page++;
            }
        }
        else
        {
            Right.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        if (point == 2)
        {
            PreGame.color = new Color(1, 1, 1, 1);
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("");
            }
        }
        else
        {
            PreGame.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        if (point == 3)
        {
            Return.color = new Color(1, 1, 1, 1);
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return)
                || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
            {
                SceneManager.LoadScene("Title");
            }
        }
        else
        {
            Return.color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
        page.text = Page + "/" + a;
        if(Page < MaxPage)
        {
            Gazou.texture = DataBase[Page].image;
        }
    }
    
}
[System.Serializable]
public class PageData
{
    public Texture2D image;
}
