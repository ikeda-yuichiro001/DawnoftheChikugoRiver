using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invinsible : MonoBehaviour
{
    public float t = 0;
    bool Switch = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && ScoreMangers.Invincible > 0)
        {
            ScoreMangers.Invincible--;
            Switch = true;
        }
        if (Switch)
        {
            t += Time.deltaTime;
            GetComponent<Renderer>().material.color = new Color(255, 255, 0, 255);
            enemyShotPattern.HitRange = 0;
            if (t > 5)
            {
                GetComponent<Renderer>().material.color = new Color(255, 0, 0, 255);
                enemyShotPattern.HitRange = 0.5f;
                t = 0;
                Switch = false;
            }
        }
    }
}
