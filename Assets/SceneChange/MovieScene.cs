using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class MovieScene : MonoBehaviour
{
    public VideoPlayer RawImage;
    float time = 0f;
    VideoClip clip;
    public float speed = 0.005f;
    float alfa =0;

    // Start is called before the first frame update
    void Start()
    {
        RawImage = GameObject.Find("Canvas/RawImage").GetComponent<VideoPlayer>();
        clip = Resources.Load("mov_hts-samp00" + StageManager.stage) as VideoClip;
        RawImage.clip = clip;
        RawImage.Play();
        //StageManager.stage = 5;
        StageManager.stage ++;
        if (StageManager.stage == 6)
        {
            StageManager.stage = 0;
            SceneLoader.LoadN("GameClear");

        }

        /* GameObject obj = (GameObject)Resources.Load("mov_hts-samp00" + stage);*/
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= clip.length + 1.0f)
        {
            GetComponent<Image>().color = new Color(255, 255, 255, alfa);
            alfa += speed;
            if (alfa >= 1)
            {
                speed = -0.005f;

            }
            if (alfa < 0)
            {
                SceneManager.LoadScene("StageScene_" + StageManager.stage);
            }
            Debug.Log(time);

        }


    }
}
 