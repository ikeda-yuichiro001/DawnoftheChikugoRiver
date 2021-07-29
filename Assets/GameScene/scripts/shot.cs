using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    int N;
    public int Power = 0;
    public static int PowData;
    public float PlacementDistance;
    [Range(0, 10)] public float Speed;
    public GameObject obj;
    [Range(0 ,20)] public float ry = 10;
    [Range(0, 120)] public float q = 0;
    public int timecount = 0;
    public GameObject Player;
    GameObject Obj;
    public GameObject[] fannels = new GameObject[4];
    // Start is called before the first frame update
    public void Start_()
    {
        fannels = new GameObject[4];
        Player = GameObject.Find("player");
    }
    
    public void UpPower()
    {
        int L = Power / 2;
        Power++;
        if (Power >= 9)
        {
            imageTest.kari += 10000 * ((int)gameObject.transform.position.z + 30);
            imageTest.scorejudge = 1;
            Power = 8;
        }
        if (Power / 2 != L)
        {
            fannels[N] = (GameObject)Instantiate(Resources.Load("fannel"), transform.position, Quaternion.identity);
            fannels[N].transform.parent = transform;
            N++;
            //Debug.Log("powerup");
            
        }
        //Debug.Log(Power);
    }
    public void DownPower()
    {
        int L = Power / 2;
        Power--;
        if (Power < 0) Power = 0;

        if (Power / 2 != L)
        {
            Destroy(fannels[N - 1].gameObject);
            fannels[N - 1] = null;
            N--;
        }
    }
    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Y))
        {
            UpPower();
            Debug.Log(Power);
        }

        //Debug.Log(Power);

        if (Input.GetKeyDown(KeyCode.U))
        {
            DownPower();
            Debug.Log(Power);
        }*/
        timecount++;
        if (timecount == 3)
        {
            timecount = 0;
        }

        ScoreMangers.Power = Power;

        if (Input.GetKey(KeyCode.Z) && timecount == 0)
        {
            switch ((Power+1)/2+1)
            {
                case 1://case Power.First:
                        shoot(0);
                    break;
                    
                case 2:
                        shoot(1);
                        shoot(-1);
                    break;

                case 3:
                    for (int v = -1; v < 2; v++)
                    {
                        Fire(transform.position, new Vector2(Mathf.Sin(v * 5f * Mathf.PI / q) * 5, Mathf.Cos(v * 5f * Mathf.PI / q) * 5));
                    }
                    break;

                case 4:
                    shoot(1);
                    shoot(-1);
                    for (int v = -1; v < 2; v++)
                    {
                        if (v != 0)
                        {
                            Fire(transform.position, new Vector2(Mathf.Sin(v * 5f * Mathf.PI / q) * 5, Mathf.Cos(v * 5f * Mathf.PI / q) * 5));
                        }
                    }
                    break;

                case 5:
                    for (int v = -2; v < 3; v++)
                    {
                        Fire(transform.position, new Vector2(Mathf.Sin(v * 5f * Mathf.PI / q) * 5, Mathf.Cos(v * 5f * Mathf.PI / q) * 5));
                    }
                    shoot(1);
                    shoot(-1);
                    break;
          
        }
    }
        switch (Power/2)
        {
            default:
                break;
            case 1:
                fannels[0].transform.localPosition = new Vector3(0, 0, 1);
                //inst_fannel(0, 1);
                break;
            case 2:

                fannels[0].transform.localPosition = new Vector3(-1, 0, 0);
                fannels[1].transform.localPosition = new Vector3( 1, 0, 0);
                //inst_fannel(-1, 0);
                //inst_fannel(1, 0);
                break;
            case 3:
                fannels[0].transform.localPosition = new Vector3(-1, 0, 0);
                fannels[1].transform.localPosition = new Vector3(0, 0, 1);
                fannels[2].transform.localPosition = new Vector3(1, 0, 0);
                //inst_fannel(0, 1);
                //inst_fannel(-1, 0);
                //inst_fannel(1, 0);
                break;
            case 4:
                fannels[0].transform.localPosition = new Vector3(-2, 0, 0);
                fannels[1].transform.localPosition = new Vector3(-1, 0, 1);
                fannels[2].transform.localPosition = new Vector3(1, 0, 1);
                fannels[3].transform.localPosition = new Vector3(2, 0, 0);
                //inst_fannel(-1, 1);
                //inst_fannel(1, 1);
                //inst_fannel(-2, 0);
                //inst_fannel(2, 0);
                break;
        }
    }
    public void shoot(int a)
    {
        Instantiate(Resources.Load("bullet"), transform.position + new Vector3(a * PlacementDistance, 0, 0) , Quaternion.identity);
    }

    public void Fire(Vector3 p, Vector2 e)
    {
        GameObject d = Instantiate(Resources.Load("bullet"), p, Quaternion.identity) as GameObject;
        d.GetComponent<sphere_des>().arrow = e;
    }
}
