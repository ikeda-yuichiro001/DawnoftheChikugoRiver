using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && ScoreMangers.Boom > 0)
        {
            Debug.Log("bomb!!");
            if (GameObject.Find("kawamutu").GetComponent<enemymove1>() != null)
            GameObject.Find("kawamutu").GetComponent<enemymove1>().hp -= 400;

            if(GameObject.Find("enemy2").GetComponent<enemymove2>() != null)
            GameObject.Find("enemy2").GetComponent<enemymove2>().hp -= 400;

            enemymove3.hp -= 400;
            Destroy(GameObject.Find("enemy_bul(Clone)").GetComponent<enemyShotPattern>().gameObject);
            Destroy(GameObject.Find("enemy_bul_big(Clone)").GetComponent<enemyShotPattern>().gameObject);
            ScoreMangers.Boom--;
            Debug.Log(ScoreMangers.Boom);
            //まだ未完成
        }
        if (Input.GetKeyDown(KeyCode.X) && ScoreMangers.Boom < 0)
        {
            Debug.Log("ボム使えない！");
        }
    }
}
