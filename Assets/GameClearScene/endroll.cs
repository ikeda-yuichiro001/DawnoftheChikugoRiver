using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endroll : MonoBehaviour
{
    public float speed;
    public float Newspeed = 50;
    public float goal;
    public float Height;
    Image image;
    public float spe = 0.005f;
    float alfa;
    // Start is called before the first frame update
    void Start()
    {
        image = GameObject.Find("Canvas/Image").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        goal = Screen.height * Height;
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;

        if (pos.y < goal)
        {
            pos.y += speed * Time.deltaTime;
            if(Input.GetKey(KeyCode.DownArrow))
            {
                pos.y += Newspeed * Time.deltaTime;
            }
        }
        else
        {
            image.color = new Color(0, 0, 0, alfa);
            alfa += spe;
            if (alfa >= 1)
            {
                SceneManager.LoadScene("Title");
            }
        }

        myTransform.position = pos;
    }
}
