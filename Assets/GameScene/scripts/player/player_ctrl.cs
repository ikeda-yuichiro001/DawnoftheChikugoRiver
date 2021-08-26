﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_ctrl : MonoBehaviour
{
    public static player_ctrl pc;
    public static int xlimit = 25;
    public static int zlimit = 35;
    float slow;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        pc = this;
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
        if (transform.position.z > zlimit)  transform.position = new Vector3(transform.position.x, transform.position.y, zlimit - 1);
        if (transform.position.z < -zlimit) transform.position = new Vector3(transform.position.x, transform.position.y, -(zlimit - 1));
        if (transform.position.x > xlimit)  transform.position = new Vector3(xlimit - 1, transform.position.y, transform.position.z);
        if (transform.position.x < -xlimit) transform.position = new Vector3(-(xlimit - 1), transform.position.y, transform.position.z);
        if (gameObject == null)
        {
            Instantiate(Resources.Load("player"),new Vector3( 0,2,-14),Quaternion.identity);
        }

        //タイトルに戻る
        title.esc();
    }
}