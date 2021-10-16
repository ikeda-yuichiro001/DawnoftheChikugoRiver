using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{
    private GameObject target;

    void Start()
    {
        // 名前でオブジェクトを特定するので一言一句合致させること（ポイント）
        target = GameObject.Find("player");
    }

    void Update()
    {
        // 「LookAtメソッド」の活用（ポイント）
        transform.LookAt(target.transform.position);
    }
}