using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove2 : MonoBehaviour
{/*
    public bool mirror = false;
    int MirrorDirection;
    int w = 0, a = 0;
    public int hp = 300;
    float cnt;
    public int t = 40;
    public float Speed;
    public float PlacementDistance;
    GameObject Player;
    float d = 100;
    public bool ishit;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        MirrorDirection = 1;
        if (mirror) MirrorDirection = -1;

        cnt += Time.deltaTime * Speed * DifficultyScene.difspd * DifficultyScene.difspd * 0.2f;                        //new
        if (cnt >= 1)                                  //new
        {
            GameObject a = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
            a.GetComponent<enemyShotPattern>().arrow = new Vector2(0,-DifficultyScene.difspd * 0.3f);
            cnt = 0;
        }

        GetComponent<Rigidbody>().position += new Vector3(-0.3f * MirrorDirection, 0, 0);

        if (transform.position.x < -27)
            transform.position = new Vector3(27,transform.position.y,transform.position.z);
        if (transform.position.x > 27)
            transform.position = new Vector3(-27, transform.position.y, transform.position.z);

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

            imageTest.kari += 100;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
        }

        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
        }

    }*/

}

