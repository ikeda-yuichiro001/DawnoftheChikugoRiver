using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool get;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
    }

    void Update()
    {
        GetComponent<Rigidbody>().position += new Vector3(0,0,-0.3f);
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<shot>() != null) {

            other.GetComponent<shot>().UpPower();
            Destroy(gameObject);
        }
    }
}
