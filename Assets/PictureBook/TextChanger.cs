/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : SceneContollor
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) point--;
        if (Input.GetKeyDown(KeyCode.DownArrow)) point++;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) point2--;
        if (Input.GetKeyDown(KeyCode.RightArrow)) point2++;
        if (point == 51) point = 0;
        if (point == -1) point = 50;
        if (point2 == 1) { point = 50; point2--; }
        if (point2 == -1) { point = 50; point2++; }
        //killのbool型
        if (!kill)
        {
            kill = false;
            text.text = "まだこの敵を他をしていないため情報がないよ。";
        }
        //説明文
        if (point == 0) text.text = "魚";
        if (point == 1) text.text = "さかな";
    }
}
*/