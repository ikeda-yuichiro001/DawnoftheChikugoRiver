using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    public EnemyController enemy;
    public static bool Finish; //new
    public float cnt;

    void Start()
    {
        Finish = false;
    }

    void Update()
    {　
        if (!Finish)
        {
            if (player == null)
            {
                Finish = true;　
            }
            if (enemy == null)
            {
                Finish = true;
            }
        }
        else
        {
            cnt += Time.deltaTime;
            if (cnt > 1f)
            {
                if (player == null)
                {
                    SceneManager.LoadScene("GameOver");
                }
                else
                { 
                    SceneManager.LoadScene("GameClear");
                } 
            }   
        }
    }
}
