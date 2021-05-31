using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeController : MonoBehaviour
{
    void Start()
    {
        GetComponent<Image>().enabled = true;
    }

    void Update()
    {
       if(Animation)
        {
            SceneManager.LoadScene("title");
        }
    }
    public void EndFadeInAnimation()
    {
        Destroy(this.gameObject);
    }
}
