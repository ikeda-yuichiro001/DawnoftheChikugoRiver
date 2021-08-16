using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_des : MonoBehaviour
{
    public bool ishit;
    float b = 0;
    GameObject sphere;
    public Rigidbody rb;
    public Vector2 arrow;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sphere = GameObject.Find("Sphere");
    }

    private void OnTriggerStay(Collider other)
    {
        if (!ishit && other.GetComponent<enemymove1>() != null)
        {
            other.GetComponent<enemymove1>().hp--;
            imageTest.kari += 10;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
            ishit = true;
        }
        if (!ishit && other.GetComponent<enemymove2>() != null)
        {
            other.GetComponent<enemymove2>().hp--;
            imageTest.kari += 10;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
            ishit = true;
        }
        if (!ishit && other.GetComponent<enemymove3>() != null)
        {
            enemymove3.hp--;
            imageTest.kari += 10;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
            ishit = true;
        }
        /*for (int i =1; i<100;i++)
        {
            string enemymove = "enemymove";
            if (!ishit && other.GetComponent < "enemymove">() != null)
            {
                other.GetComponent<enemymove>().hp--;
                Debug.Log("+10point");
                Destroy(gameObject);
                ishit = true;
            }
        }*/
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (float.IsNaN(arrow.x)) arrow.x = 0;
        if (float.IsNaN(arrow.y)) arrow.y = 0;
        rb.position += new Vector3(arrow.x, 0, arrow.y);
        b += Time.deltaTime;
        /*if (equipment == missile)
        {
            rb.AddRelativeForce(Vector3.forward*100);
        }*/
        if (b > 2)
        {
            Destroy(gameObject);
        }
    }
}
