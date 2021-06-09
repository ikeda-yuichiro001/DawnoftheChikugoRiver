using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool get;
    GameObject Player;
    GameObject Obj;
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
        if (other.CompareTag("Player")) {

            other.GetComponent<shot>().Power++;
            Obj = (GameObject)Instantiate(Resources.Load("fannel"), transform.position, Quaternion.identity);
            Obj.transform.parent = Player.transform;
            Destroy(this.gameObject);
        }
    }
}
