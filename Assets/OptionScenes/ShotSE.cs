using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSE : MonoBehaviour
{
    static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.mute = true; 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))audioSource.mute = false;
        if (Input.GetKeyUp(KeyCode.Z)) audioSource.mute = true;
    }
}
