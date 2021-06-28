using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fannel : MonoBehaviour
{
    int timecount = 0;
    //bool get = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timecount++;
        if (timecount > 10000)
        {
            timecount = 0;
        }
        if (Input.GetKey(KeyCode.Z) && timecount % 10 == 0)
        {
            Instantiate(Resources.Load("fan_bul"), transform.position, Quaternion.identity);
        }
    }
}
