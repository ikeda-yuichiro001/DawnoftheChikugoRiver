using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject enemyMissilePrefab;
    GameObject enemyMissile;
    public float speed;
    private int timeCount = 0;

    void Update()
    {
        timeCount += 1;

        if (timeCount *DifficultyScene.difspd % 30 == 0)
        {
            // 敵のミサイルを生成する
            enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす（ポイント）
            enemyMissileRb.AddForce(transform.forward * speed *DifficultyScene.difspd);


        }
    }
}
