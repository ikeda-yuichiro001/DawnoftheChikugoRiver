using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneContollor : MonoBehaviour
{
    Image BackButton;
    public int point = 0;
    public int point2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        BackButton = GameObject.Find("Canvas/BackButton").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            point--;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            point++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            point2--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            point2++;
        }

        if (point == 46)
        {
            point = 0;
        }
        if (point == -1)
        {
            point = 45;
        }
        if (point2 >= 1)
        {
            point = 45;
        }
        if (point2 <= -1)
        {
            point = 45;
        }

        if (point == 45)
        {
            BackButton.color = Color.red;
        }
        else
        {
            BackButton.color = new Color32(70, 70, 70, 100);
        }

        if(point == 45)
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                SceneManager.LoadScene("title");
            }
        }
    }
}
