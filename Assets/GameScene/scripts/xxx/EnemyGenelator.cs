using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenelator : EnemyGenelatorBehavior
{
    public GenerateData[] enemyList = new GenerateData[]
    {
        new GenerateData(){ name = "hinamoroko_model1r", pointX = -18, pointZ = 30, timer = 1},
        new GenerateData(){ name = "hinamoroko_model1r", pointX = -9, pointZ = 27,timer = 3},
        new GenerateData(){ name = "hinamoroko_model1r", pointX = 0, pointZ = 24,timer = 5},
        new GenerateData(){ name = "hinamoroko_model1r", pointX = 9, pointZ = 21,timer = 7},
        new GenerateData(){ name = "hinamoroko_model1r", pointX = 18, pointZ = 18,timer = 9},

        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 30, timer = 14},
        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 30, timer = 16},
        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 30 ,timer = 18},
        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 30, timer = 20},
        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 30, timer = 22},

        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 30, timer = 14},
        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 30, timer = 16},
        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 30, timer = 18},
        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 30, timer = 20},
        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 30, timer = 22},

        //new GenerateData(){ name}
    };
    public bool IsCreateBoss = false;
    public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timer = 0;

    // Update is called once per frame
    public override void UPDATE()
    {
        enemyList = CreateByTimer(enemyList);
        if (IsAllDead(enemyList) && !IsCreateBoss)
        {

            timer += Time.deltaTime;

            if (timer > 5)
            {
                IsCreateBoss = true;
                boss = Generate("kurumeusu2", 0, 0);
                return;
            }
        }

        if (IsCreateBoss && boss == null)
        {
            //GameClear
            //SceneManager.LoadScene("GameClear");
        }

    }
}
