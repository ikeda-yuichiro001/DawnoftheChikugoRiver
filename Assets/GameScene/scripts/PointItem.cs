using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItem : MonoBehaviour
{
    public bool get;
    GameObject Point;
    // Start is called before the first frame update
    void Start()
    {
        Point = GameObject.Find("player");
    }

    void Update()
    {
        GetComponent<Rigidbody>().position += new Vector3(0, 0, -0.3f);
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<shot>() != null)
        {
            Debug.Log("+10000point");
            Destroy(gameObject);
        }
    }
}