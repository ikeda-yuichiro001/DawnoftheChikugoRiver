using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove3 : MonoBehaviour
{
    //bool lockon = false;
    int w = 0, a = 0;
    public static int maxhp = 300;
    public static int hp = maxhp;
    float cnt;
    public int t = 40;
    public float Speed;
    public float PlacementDistance;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Player = player_ctrl.pc.gameObject;
        //gameObject.transform.position = 
        GetComponent<Rigidbody>().position += new Vector3(Mathf.Sin(Time.time * 4)/*+0.1f*/, 0, /*Mathf.Cos(Time.time*4)*-1*/0);
        cnt += Time.deltaTime * Speed * DifficultyScene.difspd;

        if (cnt >= 1)                                  //new
        {
            Vector3 jikinerai = Player.transform.position - transform.position;
            jikinerai.Normalize();

            GameObject a = Instantiate(Resources.Load("enemy_bul_big"), transform.position, Quaternion.identity) as GameObject;
            a.GetComponent<enemyShotPattern>().arrow = new Vector2(jikinerai.x, jikinerai.z) * DifficultyScene.difspd * 0.75f;
            //Debug.Log(a.GetComponent<enemyShotPattern>().arrow = new Vector2(jikinerai.x, jikinerai.z));
            cnt = 0;
        }

        //if (transform.position.z > 35 || transform.position.z < -35 || transform.position.x > 35 || transform.position.x < -35)
        //  Destroy(gameObject);
        //Debug.Log(hp);

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

            imageTest.kari += 10000000;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
        }
    }

}
