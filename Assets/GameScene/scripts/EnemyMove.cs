using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public int i = 1;
    //float t = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //t += Time.deltaTime;
        switch (i)
        {
            case 1:
                enemymove1();
                i++;
                break;

            case 2:
                enemymove2();
                i++;
                break;

            case 3:
                enemymove3();
                i++;
                break;

            case 4:
                enemymove4();
                i++;
                break;

            case 5:
                enemymove5();
                i++;
                break;

            case 6:
                enemymove6();
                i++;
                break;

            case 7:
                enemymove7();
                i++;
                break;

            case 8:
                enemymove8();
                i++;
                break;

            case 9:
                enemymove9();
                i++;
                break;

            case 10:
                enemymove10();
                i++;
                break;

            case 11:
                enemymove11();
                i++;
                break;

            case 12:
                enemymove12();
                i++;
                break;

            case 13:
                enemymove13();
                i++;
                break;

            case 14:
                enemymove14();
                i++;
                break;

            case 15:
                enemymove15();
                i = 1;
                break;
        }
    }

    void enemymove1() {
    //public 
    bool mirror = false;
    int MirrorDirection;
    int w = 0, a = 0;
    //public 
    int hp = 500;
    float cnt = 0;
    //public 
    int t = 8;
    //public 
    float Speed = 3;
    //public 
    float PlacementDistance = 3;
    GameObject Player = GameObject.Find("player"); ;
    float d = 100;
    Rigidbody rb = GetComponent<Rigidbody>();
        MirrorDirection = 1;
        if (mirror) MirrorDirection = -1;

        cnt += Time.deltaTime * DifficultyScene.difspd * DifficultyScene.difspd * 0.1f * Speed;                        //new
        if (cnt >= 1)                                  //new
        {
            for (int v = 0; v < t * DifficultyScene.difspd; v++)
            {
                GameObject aa = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
                aa.GetComponent<enemyShotPattern>().arrow = new Vector2(Mathf.Sin(v * 1f / t * Mathf.PI * 2), Mathf.Cos(v * 1f / t * Mathf.PI * 2)) * DifficultyScene.difspd * Speed * PlacementDistance / 15;
            }
            cnt = 0;
        }
        GetComponent<Rigidbody>().position += new Vector3(0, 0, -0.2f * MirrorDirection);

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

        if (transform.position.z < -player_ctrl.zlimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, player_ctrl.zlimit);
        }
        if (transform.position.z > player_ctrl.zlimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -player_ctrl.zlimit);
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
    

}
    void enemymove2()
    {

    }
    void enemymove3()
    {

    }
    void enemymove4()
    {

    }
    void enemymove5()
    {

    }
    void enemymove6()
    {

    }
    void enemymove7()
    {

    }
    void enemymove8()
    {

    }
    void enemymove9()
    {

    }
    void enemymove10()
    {

    }
    void enemymove11()
    {

    }
    void enemymove12()
    {

    }
    void enemymove13()
    {

    }
    void enemymove14()
    {

    }
    void enemymove15()
    {

    }
}
