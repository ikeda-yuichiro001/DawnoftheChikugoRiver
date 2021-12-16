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
    public AudioSource _shot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sphere = GameObject.Find("Sphere");
        _shot = GetComponent<AudioSource>();
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (!ishit && other.GetComponent<EnemyMove>() != null)
        {
            Instantiate(Resources.Load("hitSE"));
            Instantiate(Resources.Load("dead"));
            //_shot.Play();
            other.GetComponent<EnemyMove>().hp--;
            imageTest.kari += 10;
            imageTest.scorejudge = 1;
            //ここに魚の画像と説明を入れる処理
            if(Sakanadata.target != 15)
            {
                if(Sakanadata.cunt > 3)
                {
                    //Sakanadata.target = 0; //hinamoroko

                    if (other.GetComponent<enemymove1>() != null) { Sakanadata.target = 1; }
                    if (other.GetComponent<enemymove2>() != null) { Sakanadata.target = 2; }
                    if (other.GetComponent<enemymove3>() != null) { Sakanadata.target = 3; }
                    if (other.GetComponent<enemymove4>() != null) { Sakanadata.target = 4; }
                    if (other.GetComponent<enemymove5>() != null) { Sakanadata.target = 5; }
                    if (other.GetComponent<enemymove6>() != null) { Sakanadata.target = 6; }
                    if (other.GetComponent<enemymove7>() != null) { Sakanadata.target = 7; }
                    if (other.GetComponent<enemymove8>() != null) { Sakanadata.target = 8; }
                    if (other.GetComponent<enemymove9>() != null) { Sakanadata.target = 9; }
                    if (other.GetComponent<enemymove10>() != null) { Sakanadata.target = 10; }
                    if (other.GetComponent<enemymove11>() != null) { Sakanadata.target = 11; }
                    if (other.GetComponent<enemymove12>() != null) { Sakanadata.target = 12; }
                    if (other.GetComponent<enemymove13>() != null) { Sakanadata.target = 13; }
                    if (other.GetComponent<enemymove14>() != null) { Sakanadata.target = 14; }
                    if (other.GetComponent<enemymove15>() != null) { Sakanadata.target = 15; }

                    Sakanadata.cunt = 0;
                }
            }
            else
            {
                //Sakanadata.target = 0;
               
                if (other.GetComponent<enemymove1>() != null) { Sakanadata.target = 1; }
                if (other.GetComponent<enemymove2>() != null) { Sakanadata.target = 2; }
                if (other.GetComponent<enemymove3>() != null) { Sakanadata.target = 3; }

            }
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
