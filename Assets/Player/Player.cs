using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigidBody;
    public float speed;
    public float Lowspeed;
    public float nonspeed;
    public int HP = 5;

    private Vector3 player_pos;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = 0, z = 0;

        if (Input.GetKey(KeyCode.W))
        {
            z += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            z -= speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += speed;
        }
        rigidBody.position += new Vector3(x, 0, z) * Time.deltaTime;
        if((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
            speed = Lowspeed;
        }
        else
        {
            speed = nonspeed;
        }


        player_pos = transform.position; 

        player_pos.x = Mathf.Clamp(player_pos.x, -20, 20);
        player_pos.z = Mathf.Clamp(player_pos.z, -9, -3);
        transform.position = new Vector3(player_pos.x,12, player_pos.z);
    }
}