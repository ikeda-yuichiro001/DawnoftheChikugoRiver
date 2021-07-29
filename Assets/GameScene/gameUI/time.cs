using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class time : MonoBehaviour
{
    bool timeup = false;
    public float x,y;//時計の針
    public float timeT;
    public float[] timenumber = new float[3];

    public Sprite[] timeKetanumber = new Sprite[10];
    public Image[] timebox = new Image[3];
    public int kari;
    public Image movehari;
    public Quaternion movehuri;
    public float gizmoSize = 0.3f;
    public Color gizmoColor = Color.yellow;
    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }

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
        
        timeT -= Time.deltaTime ;

        if(timeT < 0 && !timeup)
        {
            enemymove3.hp = 0;
        }

        y -= Time.deltaTime;
        //timeT 

        //Quaternion movehari = Quaternion.identity;
        x -= Time.deltaTime*3;//時計の針を動かす　２分しかできない
       movehari.transform.rotation = Quaternion.Euler( 0, 0,(int)x);

        




        for (int i = 0; i < 4; i++)
        {

            switch (i)
            {
                case 1:
                    timenumber[2] = (int)timeT / 60;
                    timebox[2].sprite = timeKetanumber[(int)timenumber[2]];
                    break;
                case 2:
                    timenumber[1] = (timeT - (timenumber[2] * 60)) / 10 % 10;
                    timebox[1].sprite = timeKetanumber[(int)timenumber[1]];
                    break;
                case 3:
                    timenumber[0] = timeT % 10;
                    timebox[0].sprite = timeKetanumber[(int)timenumber[0]];
                    break;
            }


        }
    }
}