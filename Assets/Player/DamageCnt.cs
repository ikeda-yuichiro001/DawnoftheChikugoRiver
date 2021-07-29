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
        rigidBody.position += new Vector3(move.x, 0, move.y) * UnityEngine.Time.deltaTime;
        cnt += (Mathf.Abs(move.x) + Mathf.Abs(move.y)) * UnityEngine.Time.deltaTime;
        if (cnt > LifeTime)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)//ダメージ処理
    {
        if (!IsHit)
        {
            if (!IsPlayer && other.GetComponent<Player>() != null)
            {
                other.GetComponent<Player>().HP--;
                if (other.GetComponent<Player>().HP <= 0)
                {
                    SceneManager.LoadScene("GameOver");
                }
                IsHit = true;
            }
        }
    }
}
