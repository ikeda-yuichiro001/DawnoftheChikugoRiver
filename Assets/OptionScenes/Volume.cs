using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    AudioSource Sound;
    public enum volume
    {
        BGM,
        SE
    }

    public volume AudioType;
    

    void Start()
    {
        Sound = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        Sound.volume = (AudioType == volume.BGM) ? Option.BGM : Option.SE;
    }
}
