using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShotPattern : MonoBehaviour
{
    public bool ishit;
    GameObject sphere;
    GameObject Player;
    public Rigidbody rb;
    public Vector2 arrow;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sphere = GameObject.Find("Sphere");
        Player = GameObject.Find("player");
    }

    private void OnTriggerStay(Collider other)
    {
        if (!ishit && other.GetComponent<player_ctrl>() != null)
        {
            Destroy(Player);
            Destroy(gameObject);
            ishit = true;
        }
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
        if (transform.position.z > 33 || transform.position.z < -16 || transform.position.x < -28 || transform.position.x > 34)
        {
            Destroy(gameObject);
        }
    }
}
