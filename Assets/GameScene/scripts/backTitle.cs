using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            playerInst.Zanki = 3;
            ScoreMangers.Invincible = 2;
            ScoreMangers.Power = 0;
            imageTest.ScoreReset();
            title.esc();
        }
    }
}
