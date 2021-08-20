using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBGM : MonoBehaviour
{
    public bool destroy = true;
    
    void Start()
    {
        if (destroy)
        {
            //シーン遷移してもオブジェクトが消えない
            DontDestroyOnLoad(gameObject);
        }
        SceneManager.sceneLoaded += SceneLoad;
    }

    void SceneLoad(Scene nextScene, LoadSceneMode mode)
    {
        if(SceneManager.GetActiveScene().name == "Difficulty")
        {
            SceneManager.sceneLoaded -= SceneLoad;
            Destroy(gameObject);
        }
    }
}
