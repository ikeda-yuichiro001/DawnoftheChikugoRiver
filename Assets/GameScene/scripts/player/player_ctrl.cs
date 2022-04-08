using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_ctrl : MonoBehaviour
{
    public static player_ctrl pc;
    public static float xlimit = 25.5f;
    public static float zlimit = 35.5f;
    float slow;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        pc = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            slow = 0.4f;
            GetComponent<BoxCollider>().size = new Vector3(10,10,10);
        }
        else
        {
            slow = 1f;
            GetComponent<BoxCollider>().size = new Vector3(3, 3, 3);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * 50f * Time.deltaTime * slow;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * 50f * Time.deltaTime * slow;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * 50f * Time.deltaTime * slow;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * 50f * Time.deltaTime * slow;
        }
        if (transform.position.z > zlimit) transform.position -= transform.forward * 50f * Time.deltaTime;
        if (transform.position.z < -zlimit) transform.position += transform.forward * 50f * Time.deltaTime;
        if (transform.position.x > xlimit) transform.position -= transform.right * 50f * Time.deltaTime;
        if (transform.position.x < -xlimit) transform.position += transform.right * 50f * Time.deltaTime;
        if (gameObject == null)
        {
            Instantiate(Resources.Load("player"),new Vector3( 0,2,-14),Quaternion.identity);
        }
    }

    static bool blue()
    {
        return Input.GetKey(KeyCode.Z);//orで書き足すよーん
    }
    static bool red()
    {
        return Input.GetKey(KeyCode.X);
    }
    static bool yellow()
    {
        return Input.GetKey(KeyCode.C);
    }
}
