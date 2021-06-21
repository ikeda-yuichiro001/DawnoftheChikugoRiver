/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MovieScene : MonoBehaviour
{
    VideoPlayer RawImage;
    int StageNumber;
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
        RawImage.url = "file///mov+StageNumber+.mp4";
        if (Time.deltaTime >= /*ムービーの長さ*/ +1)
        {
            if (SceneLoader.IsFade) return;
            SceneLoader.Load("stage+StageNumber");
        }
    }
<<<<<<< HEAD
}

public class next
{
    int StageNumber ++;
        if(StageNumber == 5)
        {
            if (SceneLoader.IsFade) return;
            SceneLoader.Load("GameClear");
        }
        else
        {
            RawImage.url = "file///mov+StageNumber+.mp4";
        } */ 
=======
}
>>>>>>> a7fa84c4e878b56c8fdcb8054647740cb95b9b5a
