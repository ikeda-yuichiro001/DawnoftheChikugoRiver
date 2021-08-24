using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenelator : EnemyGenelatorBehavior
{
    public GenerateData[] enemyList = new GenerateData[]
    {
        new GenerateData(){ name = "Enemy01", pointX = -18, timer = 1},
        new GenerateData(){ name = "Enemy01", pointX = -9, timer = 3},
        new GenerateData(){ name = "Enemy01", pointX = 0, timer = 5},
        new GenerateData(){ name = "Enemy01", pointX = 9, timer = 7},
        new GenerateData(){ name = "Enemy01", pointX = 18, timer = 9},

        new GenerateData(){ name = "Enemy01", pointX = 12, timer = 14},
        new GenerateData(){ name = "Enemy01", pointX = 12, timer = 16},
        new GenerateData(){ name = "Enemy01", pointX = 12, timer = 18},
        new GenerateData(){ name = "Enemy01", pointX = 12, timer = 20},
        new GenerateData(){ name = "Enemy01", pointX = 12, timer = 22},

        new GenerateData(){ name = "Enemy01", pointX = -12, timer = 14},
        new GenerateData(){ name = "Enemy01", pointX = -12, timer = 16},
        new GenerateData(){ name = "Enemy01", pointX = -12, timer = 18},
        new GenerateData(){ name = "Enemy01", pointX = -12, timer = 20},
        new GenerateData(){ name = "Enemy01", pointX = -12, timer = 22},
    };
    public bool IsCreateBoss = false;
    public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void UPDATE()
    {
        enemyList = CreateByTimer(enemyList);
        if (IsAllDead(enemyList) && !IsCreateBoss)
        {
            IsCreateBoss = true;
            boss = Generate("Enemy00", 0);
        }

        if(IsCreateBoss && boss == null)
        {
            //GameClear
        }

    }
}
