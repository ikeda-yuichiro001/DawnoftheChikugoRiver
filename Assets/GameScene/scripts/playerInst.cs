using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInst : MonoBehaviour
{
    bool Zanki = false;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null || !Zanki)
        {
            Instantiate(Resources.Load("player"),new Vector3(0,2,-14),Quaternion.identity);
            Zanki = true;
        }
    }
}
