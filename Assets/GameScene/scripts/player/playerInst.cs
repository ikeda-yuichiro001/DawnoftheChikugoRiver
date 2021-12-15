using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerInst : MonoBehaviour
{
    bool gameover = false;
    public static int Zanki = 3;
    public static int bomb = 3;
    GameObject Player;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        Zanki++;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneLoader.IsFade) return;
        ScoreMangers.RetryRemain = Zanki;

        if (Player == null && Zanki>0)
        {
            Player = Instantiate(Resources.Load("player"),new Vector3(0,2,-30),Quaternion.identity) as GameObject;
            Player.name = "player";
            Player.GetComponent<shot>().Start_();
            for(int d = 0; d < shot.PowData; d++)
            Player.GetComponent<shot>().UpPower();
            Player.GetComponent<shot>().DownPower();
            Zanki --;
            ScoreMangers.RetryRemain = Zanki;
            ScoreMangers.Boom = bomb;
            /*
            t += Time.deltaTime;
            if (t > 7)
            {
                gameObject.AddComponent<BoxCollider>();
                GetComponent<BoxCollider>().isTrigger = true;
                Debug.Log("無敵消えた");
            }*/
        }
        else if(Player == null && Zanki == 0 && !gameover)
        {
            t += Time.deltaTime;
            if (t > 5) {
                Player = Instantiate(Resources.Load("player"), new Vector3(0, 2, -30), Quaternion.identity) as GameObject;
                ScoreMangers.Power = 8;
                Zanki = 3;
                if (SceneManager.GetActiveScene().name == "trial")
                { // hogehogeシーンでのみやりたい処理
                    ScoreMangers.Power = 0;
                    SceneManager.LoadScene("trial");
                }
                else
                { // それ以外のシーンでやりたい処理
                    SceneManager.LoadScene("GameOver");
                    gameover = true;
                }
            }
            
        }
    }
}
