﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreMangers.Boom = 3;
        ScoreMangers.RetryRemain = 3;
        ScoreMangers.Invincible = 2;
        imageTest.kari = 0;
    }

    // Update is called once per frame
    void Update()
    {
        title.esc();
    }
}
