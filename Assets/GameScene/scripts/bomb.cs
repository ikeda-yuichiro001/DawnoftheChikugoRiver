using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<enemymove1>().hp -= 400;
            GetComponent<enemymove2>().hp -= 400;
            enemymove3.hp -= 400;
            Destroy(GetComponent<enemyShotPattern>().gameObject);
        }
    }
}
