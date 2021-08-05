using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    static bool Destroy = true;
    
    void Start()
    {
        if (Destroy)
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    
    void Update()
    {
       
    }
}
