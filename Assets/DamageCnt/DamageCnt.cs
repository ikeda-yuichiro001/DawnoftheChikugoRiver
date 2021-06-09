using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamageCnt : MonoBehaviour
{
    public bool ishit;
    public bool IsPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)//ダメージ処理
    {
        if (!ishit && other.GetComponent<shot>() != null)
        {
            other.GetComponent<Player>().HP--;
            Destroy(gameObject);
            ishit = true;
        }
        if (GetComponent<Player>().HP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if(GetComponent<Enemy>().HP <= 0)
        {
            SceneManager.LoadScene("NextStage");
        }
    }
}
