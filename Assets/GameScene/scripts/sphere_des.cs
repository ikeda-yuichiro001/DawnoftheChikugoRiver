﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_des : MonoBehaviour
{
    public bool ishit;
    float b = 0;
    GameObject sphere;
    public Rigidbody rb;
    public Vector2 arrow;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sphere = GameObject.Find("Sphere");
    }

    private void OnTriggerStay(Collider other)
    {
        if (!ishit && other.GetComponent<enemymove1>() != null)
        {
            other.GetComponent<enemymove1>().hp--;
            Destroy(gameObject);
            ishit = true;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (float.IsNaN(arrow.x)) arrow.x = 0;
        if (float.IsNaN(arrow.y)) arrow.y = 0;
        rb.position += new Vector3(arrow.x, 0, arrow.y);
        b += Time.deltaTime;
        /*if (equipment == missile)
        {
            rb.AddRelativeForce(Vector3.forward*100);
        }*/
        if (b > 2)
        {
            Destroy(gameObject);
        }
    }
}