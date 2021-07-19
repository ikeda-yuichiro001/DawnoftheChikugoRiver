using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInst : MonoBehaviour
{
    bool gameover = false;
    int Zanki = 5;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneLoader.IsFade) return;
        if (Player == null && Zanki>0)
        {
            Player = Instantiate(Resources.Load("player"),new Vector3(0,2,-14),Quaternion.identity) as GameObject;
            Player.name = "player";
            Player.GetComponent<shot>().Start_();
            for(int d = 0; d < shot.PowData; d++)
            Player.GetComponent<shot>().UpPower();
            Player.GetComponent<shot>().DownPower();
            Zanki --;
            Debug.Log("残機：" + Zanki);
            Debug.Log("Power:" +Player.GetComponent<shot>().Power);
        }
        else if(Player == null && Zanki == 0 && !gameover)
        {
            Instantiate(Resources.Load("player_ghost"), new Vector3(0, 2, -14), Quaternion.identity);
            SceneLoader.Load("GameOver");
            gameover = true;
        }
    }
}
