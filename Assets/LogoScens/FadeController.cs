using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeController : MonoBehaviour
{
    void Start()
    {
        GetComponent<Image>().enabled = true;
    }

    void Update()
    {
        
    }
    public void EndFadeInAnimation()
    {
        Destroy(this.gameObject);
    }
}
