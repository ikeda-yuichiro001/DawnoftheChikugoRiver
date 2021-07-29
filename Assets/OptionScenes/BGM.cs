using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    
    void Start()
    {
        if (DontDestroyEnabled)
        {
            //シーン遷移してもBGMが流れ続ける
            DontDestroyOnLoad(this);
        }
    }

    
    void Update()
    {
        
    }
}
