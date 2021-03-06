using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum AttackPattern { Single, Double, Round }
    public AttackPattern pattern;
    public float cnt;
    public float PlacementDistance;
    [Range(0, 5)] public float Speed;
    public int HP = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (pattern)
        {
            case AttackPattern.Single:
                {
                    cnt += Time.deltaTime * Speed;
                    if (cnt >= 1)
                    {
                        cnt = 0;
                    }
                }
                break;
            case AttackPattern.Round:
                {
                    cnt += Time.deltaTime * Speed;
                    if (cnt >= 1)
                    {
                        for (int v = 0; v < 40; v++)
                        {
                            GameObject a = Instantiate(Resources.Load("barrage"), transform.position, Quaternion.identity) as GameObject;
                            a.GetComponent<DamageCnt>().move = new Vector2(Mathf.Sin(v * 1f / 40 * Mathf.PI * 2), Mathf.Cos(v * 1f / 40 * Mathf.PI * 2));
                        }
                        cnt = 0;
                    }
                }
                break;
        }

    }
}