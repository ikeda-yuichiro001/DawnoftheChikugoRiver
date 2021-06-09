using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove1 : MonoBehaviour
{
    public int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().position += new Vector3(0,0,-0.1f);
        if (hp <= 0)
        {
            Instantiate(Resources.Load("Item"), transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
