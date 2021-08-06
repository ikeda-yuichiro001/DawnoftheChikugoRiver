using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombShotBoom : MonoBehaviour
{
    SphereCollider SphereCollider;
    float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        SphereCollider = GetComponent<SphereCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(1, 1, 1);
        //SphereCollider.center += new Vector3(1, 1, 1);
        t += Time.deltaTime;

        if (t > 2)
        {
            Destroy(gameObject);
            Destroy(this);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<enemyShotPattern>() != null)
        {
            Destroy(other.gameObject);
        }
        
        if(other.GetComponent<enemymove1>() != null)
        {
            other.GetComponent<enemymove1>().hp -= 2;
            imageTest.kari += 100;
        }
        if (other.GetComponent<enemymove2>() != null)
        {
            other.GetComponent<enemymove2>().hp -= 2;
            imageTest.kari += 100;
        }
        if (other.GetComponent<enemymove3>() != null)
        {
            enemymove3.hp -= 2;
            imageTest.kari += 100;
        }
    }
}
