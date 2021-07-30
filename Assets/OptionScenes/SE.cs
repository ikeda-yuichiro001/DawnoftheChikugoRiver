using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    //定義
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public AudioClip sound7;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            audioSource.PlayOneShot(sound1);//ショット
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            audioSource.PlayOneShot(sound2);//ボム
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            audioSource.PlayOneShot(sound3);//無敵
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            audioSource.PlayOneShot(sound4);//回復
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            audioSource.PlayOneShot(sound5);//パワーアップ
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            audioSource.PlayOneShot(sound6);//残機増やす
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            audioSource.PlayOneShot(sound7);//残機減らす
        }
    }
}
