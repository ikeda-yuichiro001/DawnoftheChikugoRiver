using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove1 : MonoBehaviour
{
    int w = 0, a = 0;
    public int hp = 500;
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
            for (int v = 0; v < t; v++)
            {
                GameObject a = Instantiate(Resources.Load("enemy_bul"), transform.position , Quaternion.identity) as GameObject; //new
                a.GetComponent<enemyShotPattern>().arrow = new Vector2(Mathf.Sin(v * 1f / t * Mathf.PI * 2), Mathf.Cos(v * 1f / t * Mathf.PI * 2));
            }
            cnt = 0;
        }
        GetComponent<Rigidbody>().position += new Vector3(0,0,-0.1f);

        if (hp <= 0)
        {

            while (w<50){
                //Debug.Log(a);
                //Debug.Log(w);

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

        if (transform.position.z > player_ctrl.zlimit || transform.position.z < -player_ctrl.zlimit || transform.position.x < -player_ctrl.xlimit || transform.position.x > player_ctrl.xlimit)
        {
            Destroy(gameObject);
        }
    }

}
