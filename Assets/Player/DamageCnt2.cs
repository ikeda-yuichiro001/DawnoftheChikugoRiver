using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageCnt2 : MonoBehaviour
{
    Rigidbody rigidBody;
    public Vector2 move;
    float cnt;
    public float LifeTime;
    public bool IsHit;
    public bool IsEnemy;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        rigidBody.position += new Vector3(move.x, 0, move.y) * Time.deltaTime;
        cnt += (Mathf.Abs(move.x) + Mathf.Abs(move.y)) * Time.deltaTime;
        if (cnt > LifeTime)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (!IsHit)
        {
            if (!IsEnemy && other.GetComponent<Enemy>() != null)
            {
                other.GetComponent<Enemy>().HP--;
                if (other.GetComponent<Enemy>().HP <= 0)
                {
                    SceneManager.LoadScene("NextStage");
                }
                IsHit = true;
            }
        }
    }
}
