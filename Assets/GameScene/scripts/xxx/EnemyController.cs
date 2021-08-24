using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Action { MoveX, Move8, MoveTarget, MovePoint, Free }
public enum AttackPattern { Single, Double, Round }

public class EnemyController : MonoBehaviour
{
    public Action action;
    Action actionLast;

    public Vector3 origin;
    public Vector3 targetPoint;

    float time8, timeX;
    public float Move8Scale;
    public float MoveXScale;

    [Range(0f, 1f)]
    public float MovePointSpeed;







    public AttackPattern pattern;
    public float cnt;
    public float PlacementDistance;

    [Range(0, 5)] public float Speed;
    public int HP = 2000;
    public int MaxHP = 2000;//new!!

    void Start()
    {
        HP = MaxHP;//new!! 
        actionLast = action;
        origin = transform.position;
        time8 = 0;
    }

    void Update()
    {
        if (HP <= 0)
        {
            //死ぬときにエフェクトを出したいならこのタイミング!!
            Debug.Log("敵は死んだ!!");
            Destroy(gameObject);
        }

        if (GameManager.Finish) return;

        if (action != actionLast)
        {
            time8 = 0;
            timeX = 0;
            actionLast = action;
        }



        switch (action)
        {
            case Action.Move8:
                time8 += Time.deltaTime;
                transform.position = origin + new Vector3(Mathf.Sin(time8) * Move8Scale, 0, Mathf.Sin(time8 * 2) * Move8Scale);
                break;


            case Action.MoveX:
                timeX += Time.deltaTime;
                transform.position = origin + new Vector3(Mathf.Sin(timeX) * MoveXScale, 0, 0);
                break;

            case Action.MovePoint:
                transform.position += (origin - transform.position) * Time.deltaTime * MovePointSpeed;
                if (Vector3.Distance(transform.position, origin) < 0.1f)
                {
                    transform.position = origin;
                    action = Action.Free;
                }
                break;

            case Action.MoveTarget:
                transform.position += (targetPoint - transform.position) * Time.deltaTime * MovePointSpeed;
                if (Vector3.Distance(transform.position, targetPoint) < 0.1f)
                {
                    transform.position = targetPoint;
                    action = Action.Free;
                }
                break;

            case Action.Free: break;

            default: break;
        }



        switch (pattern)
        {
            case AttackPattern.Single:
                {
                    cnt += Time.deltaTime * Speed;
                    if (cnt >= 1)
                    {
                        GameObject g = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject;
                        cnt = 0;
                    }
                }
                break;


            case AttackPattern.Double:
                {
                    cnt += Time.deltaTime * Speed; //add !!
                    if (cnt >= 1)
                    {
                        Instantiate(Resources.Load("enemy_bul"), transform.position + new Vector3(1, 0, 0) * PlacementDistance, Quaternion.identity); //new
                        Instantiate(Resources.Load("enemy_bul"), transform.position + new Vector3(-1, 0, 0) * PlacementDistance, Quaternion.identity); //new
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
                            GameObject a = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject;
                            a.GetComponent<enemyShotPattern>().arrow = new Vector2(Mathf.Sin(v * 1f / 40 * Mathf.PI * 2), Mathf.Cos(v * 1f / 40 * Mathf.PI * 2));
                        }
                        cnt = 0;
                    }
                }
                break;
        }

    }

}
