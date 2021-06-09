using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageCnt : MonoBehaviour
{
    Rigidbody rigidBody;
    public Vector2 move;
    float cnt;
    public float LifeTime;
    public bool IsHit;
    public bool IsPlayer;
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
        if (GetComponent<Player>().HP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if (GetComponent<Enemy>().HP <= 0)
        {
            SceneManager.LoadScene("NextStage");
        }
    }
    public void OnTriggerStay(Collider other)//ダメージ処理
    {
        if (!IsHit)
        {
            if (!IsPlayer && other.GetComponent<Player>() != null)
            {
                other.GetComponent<Player>().HP--;
                IsHit = true;
            }
            else if (IsPlayer && other.GetComponent<Enemy>() != null)
            {
                other.GetComponent<Enemy>().HP--;
                IsHit = true;
            }
        }
    }
}
