using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stagetext : DifficultyScene
{
    Text Stage;
    Text Level;
    void Start()
    {
        Stage = GameObject.Find("Canvas/Stage").GetComponent<Text>();
        Level = GameObject.Find("Canvas/Level").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            Stage.text = "ステージ:" + "1";
        }
        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            Stage.text = "ステージ:" + "2";
        }
        if (SceneManager.GetActiveScene().name == "Stage2-2")
        {
            Stage.text = "ステージ:" + "2-2";
        }
        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            Stage.text = "ステージ:" + "3";
        }
        if (SceneManager.GetActiveScene().name == "Stage3-2")
        {
            Stage.text = "ステージ:" + "3-2";
        }
        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            Stage.text = "ステージ:" + "4";
        }
        if (SceneManager.GetActiveScene().name == "Stage4-2")
        {
            Stage.text = "ステージ:" + "4-2";
        }
        if (SceneManager.GetActiveScene().name == "Stage5")
        {
            Stage.text = "ステージ:" + "5";
        }
        if (SceneManager.GetActiveScene().name == "Stage5-2")
        {
            Stage.text = "ステージ:" + "5-2";
        }
        switch(difspd)
        {
            case 1: Level.text = "難易度:Easy"; break;
            case 2: Level.text = "難易度:Normal"; break;
            case 3: Level.text = "難易度:Hard"; break;
            case 4: Level.text = "難易度:VeryHard"; break;
        }
    }
}
