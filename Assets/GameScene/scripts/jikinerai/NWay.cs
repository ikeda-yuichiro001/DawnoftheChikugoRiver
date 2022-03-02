using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NWay : MonoBehaviour
{
    public GameObject enemyFireMissilePrefab;
    // 何方向（何Way）ミサイルを発射するかを決める
    public int wayNumber;

    void Start()
    {
        // for文（繰り返し文）を活用する（重要ポイント）
        for (int i = 0; i < wayNumber; i++)
        {
            // Instantiate()は、プレハブからクローンを産み出すメソッド（重要ポイント）
            // Quaternion.Euler(x, y, z)
            GameObject enemyFireMissile = Instantiate(enemyFireMissilePrefab, transform.position, Quaternion.Euler(0, 7.5f - (7.5f * wayNumber) + (15.0f * i), 0));

            // SetParent()は親子関係を作るメソッド（ポイント）
            // 『このスクリプトが付いているNWayオブジェクトをenemyFireMissileクローンの親に設定する。』
            enemyFireMissile.transform.SetParent(this.gameObject.transform);
        }
    }
}
