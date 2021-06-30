﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureChanger : SceneContollor
{
    public Image image;
    private Sprite sprite;

    void Start()
    {
        image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.sprite = Resources.Load<Sprite>("0" + point);

        if (Input.GetKeyDown(KeyCode.UpArrow))  point--;
        if (Input.GetKeyDown(KeyCode.DownArrow))point++;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) point2--;
        if (Input.GetKeyDown(KeyCode.RightArrow))point2++;
        if (point == 51)point = 0;
        if (point == -1)point = 50;
        if (point2 == 1) { point = 50; point2--; }
        if (point2 == -1) { point = 50; point2++; }

        Debug.Log(point);
    }
}