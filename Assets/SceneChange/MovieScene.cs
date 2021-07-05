using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MovieScene : StageManager
{
    public VideoPlayer RawImage;
    float time = 0f;
    VideoClip clip;

    // Start is called before the first frame update
    void Start()
    {
        RawImage = GameObject.Find("Canvas/RawImage").GetComponent<VideoPlayer>();
        clip = Resources.Load("mov_hts-samp00" + stage) as VideoClip;
        GameObject obj = (GameObject)Resources.Load("mov_hts-samp00" + stage);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        RawImage.clip= clip;
        if (Time.deltaTime >= /*ムービーの長さ*/ +1)
        {
            if (SceneLoader.IsFade) return;
            SceneLoader.Load("battle"+stage);
        }
    }
    public void playvideo()
    {
        RawImage.clip = clip;
        RawImage.Play();
    }
}
 