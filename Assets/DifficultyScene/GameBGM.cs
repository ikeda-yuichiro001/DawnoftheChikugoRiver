using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBGM : MonoBehaviour
{
    public  bool Destroy_ = true;
    
    void Start()
    {
        if (Destroy_)
        {
            //シーン遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(gameObject);
        }

        SceneManager.sceneLoaded += SceneLoaded;
    }


    void SceneLoaded(Scene nextScene, LoadSceneMode mode) 
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            SceneManager.sceneLoaded -= SceneLoaded;
            Destroy(gameObject);
        }
    }
}
