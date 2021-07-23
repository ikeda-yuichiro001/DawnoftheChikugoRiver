﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShotPattern : MonoBehaviour
{
    float d = 1;
    public bool ishit;
    //GameObject sphere;
    //GameObject bsphere;
    GameObject Player;
    //GameObject core;
    public Rigidbody rb;
    public Vector2 arrow;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //sphere = GameObject.Find("enemy_bul");
        //bsphere = GameObject.Find("enemy_bul_big");
        Player = GameObject.Find("player");
        //core = GameObject.Find("player/core");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (float.IsNaN(arrow.x)) arrow.x = 0;
        if (float.IsNaN(arrow.y)) arrow.y = 0;
        rb.position += new Vector3(arrow.x, 0, arrow.y);

        /*if (equipment == missile)
        {
            rb.AddRelativeForce(Vector3.forward*100);
        }*/
        if (transform.position.z > player_ctrl.zlimit || transform.position.z < -player_ctrl.zlimit || transform.position.x < -player_ctrl.xlimit || transform.position.x > player_ctrl.xlimit)
        {
            Destroy(gameObject);
        }

        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 0.5f&&!ishit)
        {
            Destroy(gameObject);
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
            ishit = true;
        }
    }
}
