﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fannel : shot
{
    //bool get = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timecount++;
        if (timecount > 10000)
        {
            timecount = 0;
        }
        if (Input.GetButton("z") && timecount % 25 == 0)
        {
            shoot(0);
        }
    }
}
