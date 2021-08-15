using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBGM : MonoBehaviour
{
    public static bool Destroy = true;
    
    void Start()
    {
        if (Destroy)
        {
            //シーン遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(this);
        }
    }


    void Update()
    {
        
    }
}
