﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endroll : MonoBehaviour
{
    public float speed =50;
    public float goal=3000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;

        if (pos.y < goal)
        {
            pos.y += speed * Time.deltaTime;
        }
        else
        {
            if (SceneLoader.IsFade) return;
            SceneLoader.Load("title");
        }

        myTransform.position = pos;
    }
}