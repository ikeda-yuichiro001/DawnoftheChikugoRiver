using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMvol : OptionButton
{
    AudioSource bgm;
    // Start is called before the first frame update
    void Start()
    {
        bgm = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (point == 0 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            bgm.volume += 0.01f;
        }

        if (point == 0 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            bgm.volume -= 0.01f;
        }
    }
}
