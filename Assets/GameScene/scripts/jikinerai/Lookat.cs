using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{
    private GameObject target;

    void Start()
    {
        // 名前でオブジェクトを特定するので一言一句合致させること（ポイント）
        //target = GameObject.Find("player");
    }

    void Update()
    {
        if (target == null) { }
            target = GameObject.Find("player");
        if (GameObject.Find("player") == null)
            transform.LookAt(Vector3.back);
        else
            transform.LookAt(target.transform.position);
    }
}