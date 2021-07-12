using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class time : MonoBehaviour
{

    public int timeS;
    public float timeT;
    public float[] timenumber = new float[3];

    public Sprite[] timeKetanumber = new Sprite[10];
    public Image[] timebox = new Image[3];
    public int kari;

    // Start is called before the first frame update
    void Start()
    {
        timeT = 120;



        //timeM = timeT/60;
        //timeS = timeT/60;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( kari == 0)
        
        {
            timeT -= Time.deltaTime ;

            for (int i = 0; i < 4; i++)
            {

                switch (i)
                {
                    case 1:
                        timenumber[2] = (int)(timeT / 60);
                        timebox[2].sprite = timeKetanumber[(int)timenumber[2]];
                        break;
                    case 2:
                        timenumber[1] = (int)((timeT-(timenumber[2]*60)) / 10 % 10);
                        timebox[1].sprite = timeKetanumber[(int)timenumber[1]];
                        break;
                    case 3:
                        timenumber[0] = (int)(timeT % 10);
                        timebox[0].sprite = timeKetanumber[(int)timenumber[0]];
                        break;
                }
                
            }
        }
    }
}