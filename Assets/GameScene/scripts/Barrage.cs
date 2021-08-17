using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrage : MonoBehaviour
{
    Rigidbody rigidBody;
    public Vector2 move;
    float cnt;             
    public float LifeTime;
    public bool IsHit;  
    public bool IsPlayer; //new

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
        rigidBody.position += new Vector3(move.x, 0, move.y) * Time.deltaTime; 
        cnt += ( Mathf.Abs(move.x) + Mathf.Abs(move.y) ) * Time.deltaTime;  
        if (cnt > LifeTime) Destroy(gameObject);                         
    }


    public void OnTriggerStay(Collider other)
    {
        if (GameManager.Finish) return;

        if (!IsHit) //if(IsHit == false) 
        { 
            if (!IsPlayer && other.GetComponent<Player>() != null)
            {  
                other.GetComponent<Player>().HP--;//new 
                IsHit = true; 
            }

            else if (IsPlayer && other.GetComponent<EnemyController>() != null)
            {
                other.GetComponent<EnemyController>().HP--;//new
                IsHit = true; 
            }
        }
    } 
     
}

// [1]    Mathf.Abs(???) は ???の絶対値を返す
//あたったらダメージ
//動く
//--------------------
//その他創意工夫