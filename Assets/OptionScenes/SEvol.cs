using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEvol : OptionButton
{
    AudioSource se;
    // Start is called before the first frame update
    void Start()
    {
        se = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        se.volume = 0;
    
        if (point == 1 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            se.volume += 0.01f;
        }

        if (point == 1 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            se.volume -= 0.01f;
        }
    }
}
