using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class time : MonoBehaviour
{

    public int timeS;
    public int timeT;
    public int[] timenumber = new int[3];

    public Sprite[] timeKetanumber = new Sprite[10];
    public Image[] timebox = new Image[3];
    public int kari;

    // Start is called before the first frame update
    void Start()
    {
        timeT = 110;



        //timeM = timeT/60;
        //timeS = timeT/60;
    }

    // Update is called once per frame
    void Update()
    {
        timeT -= (int)Time.deltaTime;
        if ( kari == 0)
        {

            for (int i = 0; i < 4; i++)
            {

                switch (i)
                {
                    case 1:
                        timenumber[2] = (int)((int)timeT / 60);
                        timebox[2].sprite = timeKetanumber[timenumber[2]];
                        break;
                    case 2:
                        timenumber[1] = (int)((int)(timeT-(timenumber[2]*60)) / 10 % 10);
                        timebox[1].sprite = timeKetanumber[timenumber[1]];
                        break;
                    case 3:
                        timenumber[0] = (int)((int)timeT % 10);
                        timebox[0].sprite = timeKetanumber[timenumber[0]];
                        break;
                }
                
            }
        }
    }
}