using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    GameObject Bullet;
    GameObject BigBullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Bullet = GameObject.FindWithTag("Respawn");
        BigBullet = GameObject.Find("enemy_bul_big(Clone)");

        if (Input.GetKeyDown(KeyCode.X) && ScoreMangers.Boom > 0)
        {
            Debug.Log("bomb!!");

            ScoreMangers.Boom--;

            enemymove3.hp -= 400;

            if (GameObject.Find("kawamutu") != null)
            {
                GameObject.Find("kawamutu").GetComponent<enemymove1>().hp -= 400;
            }
            else
            {
                //null
            }

            if(GameObject.Find("enemy2") != null)
            {
                GameObject.Find("enemy2").GetComponent<enemymove2>().hp -= 400;
            }
            else
            {

            }

            Destroy(Bullet.GetComponent<enemyShotPattern>().gameObject);
            Destroy(BigBullet.GetComponent<enemyShotPattern>().gameObject);
            Debug.Log(ScoreMangers.Boom);
            //まだ未完成
        }
        if (Input.GetKeyDown(KeyCode.X) && ScoreMangers.Boom < 0)
        {
            Debug.Log("ボム使えない！");
        }
    }
}
