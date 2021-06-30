using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MovieScene : StageManager
{
    public VideoPlayer RawImage;
    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        RawImage = GameObject.Find("RawImage").GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        RawImage.url = "file://C:/Users/Owner/Desktop/mp4file_sample/mov_hts-samp00"+ stage +".mp4";
        if (Time.deltaTime >= /*ムービーの長さ*/ +1)
        {
            if (SceneLoader.IsFade) return;
            SceneLoader.Load("title");
        }
    }
}