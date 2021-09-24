using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShotLockOn : MonoBehaviour
{
    public GameObject enemyMissilePrefab;
    public float speed;
    public int wayNumber;
    public GameObject enemyFireMissilePrefab;
    private float cnt = 0;
    private GameObject look;

    private void Start()
    {
        // for文（繰り返し文）を活用する（重要ポイント）
        for (int i = 0; i < wayNumber; i++)
        {
            // Instantiate()は、プレハブからクローンを産み出すメソッド（重要ポイント）
            // Quaternion.Euler(x, y, z)
            // 今回は「i = 0の時 → y = -30」「i = 1の時 → y = -15」「i = 2の時 → y = 0」「i = 3の時 → y = 15」「i = 4の時 → y = 15」になるようにする。
            Instantiate(enemyFireMissilePrefab, transform.position, Quaternion.Euler(0, -30 + (15 * i), 0));
        }
    }

    void Update()
    {
        if(look==null)
        look = GameObject.Find("player");
        transform.LookAt(look.transform.position);
        cnt += Time.deltaTime * DifficultyScene.difspd * DifficultyScene.difspd * 0.33f;

        if (cnt >= 1)
        {
            // 敵のミサイルを生成する
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // ミサイルを飛ばす方向を決める。「forward」は「z軸」方向をさす（ポイント）
            enemyMissileRb.AddForce(transform.forward * speed * DifficultyScene.difspd);

            cnt = 0;
        }
    }
}
