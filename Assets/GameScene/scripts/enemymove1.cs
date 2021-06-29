using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove1 : MonoBehaviour
{
    int w = 0, a = 0;
    public int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().position += new Vector3(0,0,-0.1f);
        if (hp <= 0)
        {

            while (w<50){
                Debug.Log(a);
                Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }
            
            Debug.Log("+100point");
            Destroy(gameObject);
        }
    }

}
