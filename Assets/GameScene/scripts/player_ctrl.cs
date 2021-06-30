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
            GetComponent<BoxCollider>().size = new Vector3(10,10,10);
        }
        else
        {
            slow = 1f;
            GetComponent<BoxCollider>().size = new Vector3(3, 3, 3);
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
        if (transform.position.z > 33)  transform.position = new Vector3(transform.position.x, transform.position.y, 32);
        if (transform.position.z < -16) transform.position = new Vector3(transform.position.x, transform.position.y, -15);
        if (transform.position.x > 34)  transform.position = new Vector3(33, transform.position.y, transform.position.z);
        if (transform.position.x < -28) transform.position = new Vector3(-27, transform.position.y, transform.position.z);
        {

        }
    }
}
