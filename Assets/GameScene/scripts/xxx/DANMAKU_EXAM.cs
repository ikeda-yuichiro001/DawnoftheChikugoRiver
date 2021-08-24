using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DANMAKU_EXAM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 内トロコイド曲線による弾幕。星形の形状になる
    /// 軸円の半径をA,動円の半径をB,描画点の軸からの距離がDとすると
    /// 
    /// ((A-B)*Cosθ + D*Cos((A-B/D)θ) , ) 
    /// </summary>
    /// <param name="startPoint"></param>
    public static void HypoTrochoid(Vector3 startPoint)
    {
        float A = 10, B = 3, D = 4, sita = 40;
        for (int v = 0; v < 40; v++)
        {
            GameObject a = Instantiate(Resources.Load("Barrage_"), startPoint, Quaternion.identity) as GameObject;
            a.GetComponent<Barrage>().move = new Vector2((A - B) * Mathf.Cos(sita) +D * Mathf.Cos((A - B / D)*sita), (A - B) * Mathf.Sin(sita) + D * Mathf.Sin((A - B / D) * sita));
        }
    }
}
