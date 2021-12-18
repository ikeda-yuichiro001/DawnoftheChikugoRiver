using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenelator1 : EnemyGenelatorBehavior
{
    public GenerateData[] enemyList = new GenerateData[]
    {
        new GenerateData(){ name = "hinamoroko_model1r", pointX = -25, pointZ = 30, timer = 1},
        new GenerateData(){ name = "hinamoroko_model1l", pointX = 25, pointZ = 27,timer = 3},
        new GenerateData(){ name = "hinamoroko_model1r", pointX = -25, pointZ = 24,timer = 5},
        new GenerateData(){ name = "hinamoroko_model1l", pointX = 25, pointZ = 21,timer = 7},
        new GenerateData(){ name = "hinamoroko_model1r", pointX = -25, pointZ = 18,timer = 9},

        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 35, timer = 14},
        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 35, timer = 16},
        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 35 ,timer = 18},
        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 35, timer = 20},
        new GenerateData(){ name = "kawamutu1", pointX = 12, pointZ = 35, timer = 22},

        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 35, timer = 14},
        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 35, timer = 16},
        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 35, timer = 18},
        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 35, timer = 20},
        new GenerateData(){ name = "kawamutu1", pointX = -12, pointZ = 35, timer = 22},

        new GenerateData(){ name = "parent", pointX = -15, pointZ = 15, timer = 25},
        new GenerateData(){ name = "parent", pointX = 15, pointZ = 15, timer = 25},

        new GenerateData(){ name = "yaritanago_model", pointX = -10, pointZ = 15, timer = 60},
        new GenerateData(){ name = "yaritanago_model", pointX = 10, pointZ = 15, timer = 60},

        new GenerateData(){ name = "aburabote_model", pointX = 0, pointZ = 10, timer = 90}
    };
    public bool IsCreateBoss = false;
    public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timer = 0;

    public MeshRenderer meshRenderer;

    public float value_;
    public Color c;
    public Color a = Color.white;
    public Color b = Color.white;
    // Update is called once per frame
    public override void UPDATE()
    {
        enemyList = CreateByTimer(enemyList);
        if (IsAllDead(enemyList) && !IsCreateBoss)
        {
            
            timer += Time.deltaTime;
            
            if (timer > 25)
            {
                IsCreateBoss = true;
                boss = Generate("kurumeusu2", 0, 0);
                return;
            }
        }

        if (IsCreateBoss)
            value_ += Time.deltaTime;

        c = Color.Lerp(a, b, value_);
        meshRenderer.material.color = c;
            

        /*if(IsCreateBoss && boss == null)
        {
            //GameClear
        }*/

    }
}
