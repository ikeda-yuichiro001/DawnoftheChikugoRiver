using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public float speed = 0.005f;
    float alfa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().color = new Color(255, 255, 255, alfa);
        alfa += speed;
        if (alfa >= 1)
        {
            speed = -0.005f;
            
        }
        if (alfa < 0)
        {
            SceneManager.LoadScene("title");
        }
        Debug.Log(alfa);
    }
}
