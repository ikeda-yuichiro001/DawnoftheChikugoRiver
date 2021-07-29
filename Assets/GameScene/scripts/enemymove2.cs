using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove2 : MonoBehaviour
{
    int w = 0, a = 0;
    public int hp = 300;
    float cnt;
    public int t = 40;
    public float Speed;
    public float PlacementDistance;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        cnt += Time.deltaTime * Speed * DifficultyScene.difspd;                        //new
        if (cnt >= 1)                                  //new
        {
            GameObject a = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
            a.GetComponent<enemyShotPattern>().arrow = new Vector2(0,-1);
            cnt = 0;
        }

        GetComponent<Rigidbody>().position += new Vector3(-0.1f, 0, 0);

        if (transform.position.z > 35 || transform.position.z < -18 || transform.position.x > 36 || transform.position.x < -30)
            Destroy(gameObject);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            Debug.Log("+100point");
            Destroy(gameObject);
        }

        if (transform.position.z > 37 || transform.position.z < -20 || transform.position.x < -32 || transform.position.x > 38)
        {
            Destroy(gameObject);
        }
    }

}

