using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endroll : MonoBehaviour
{
    public float speed =100;
    public float Newspeed = 300;
    public float goal=3000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
            SceneManager.LoadScene("Title");
        }

        myTransform.position = pos;
    }
}
