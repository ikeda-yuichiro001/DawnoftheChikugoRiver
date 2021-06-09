using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public int Power = 0;
    public float PlacementDistance;
    [Range(0, 10)] public float Speed;
    public GameObject obj;
    [Range(0 ,20)] public float ry = 10;
    [Range(0, 120)] public float q = 0;
    public int timecount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timecount++;
        if (timecount > 10000)
        {
            timecount = 0;
        }



        switch (Power)
        {
            default://case Power.First:
                if (Input.GetButton("z") && timecount % 3 == 0)
                {
                    shoot(0);
                }
                break;

            case 1:
                if (Input.GetButton("z") && timecount % 3 == 0)
                {
                    shoot(1);
                    shoot(-1);
                }
                break;

            case 2:
                if (Input.GetButton("z") && timecount % 3 == 0)
                {
                    for (int v = -1; v < 2; v++)
                    {
                        Fire(transform.position, new Vector2(Mathf.Sin(v * 5f * Mathf.PI / q) * 5, Mathf.Cos(v * 5f * Mathf.PI / q) * 5));
                    }
                }
                break;

            case 3:
                if (Input.GetButton("z") && timecount % 3 == 0)
                {
                    shoot(1);
                    shoot(-1);
                    for (int v = -1; v < 2; v++)
                    {
                        if (v != 0) {
                            Fire(transform.position, new Vector2(Mathf.Sin(v * 5f * Mathf.PI / q) * 5, Mathf.Cos(v * 5f * Mathf.PI / q) * 5));
                        }
                    }
                }
                break;

            case 4:
                if (Input.GetButton("z") && timecount % 3 == 0)
                {
                    for (int v = -2; v < 3; v++)
                    {
                        Fire(transform.position, new Vector2(Mathf.Sin(v * 5f * Mathf.PI / q) * 5, Mathf.Cos(v * 5f * Mathf.PI / q) * 5));
                    }
                    shoot(1);
                    shoot(-1);
                }
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
