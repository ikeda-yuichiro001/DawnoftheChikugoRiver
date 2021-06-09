using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_ctrl : MonoBehaviour
{
    float slow;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            slow = 0.4f;
        }
        else
        {
            slow = 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().position += new Vector3(-1, 0, 0) * slow;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().position += new Vector3(1, 0, 0) * slow;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().position += new Vector3(0, 0, 1) * slow;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().position += new Vector3(0, 0, -1) * slow;
        }
    }
}
