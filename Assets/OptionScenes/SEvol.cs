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
        if (point == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                se.volume += 0.01f;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                se.volume -= 0.01f;
            }
        }

        if (point == 2 && Input.GetKeyDown(KeyCode.Z))
        {
            se.volume = 0.50f;
        }
    }
}
