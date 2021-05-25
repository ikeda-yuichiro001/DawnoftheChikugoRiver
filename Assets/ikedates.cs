using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikedates : MonoBehaviour
{ 
    void Update()
    { 
        if (SceneLoader.IsFade) return;// フェード中は処理しない
        SceneLoader.Load("シーン名");//かわりにこれを...
    }
}
