using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenelatorBehavior : MonoBehaviour
{
    protected float timer;

    public virtual void UPDATE() { }

    public void Update()
    {
        timer += Time.deltaTime;
        UPDATE();
    }

    protected GenerateData[] CreateByTimer(GenerateData[] d)
    {
        for(int i = 0;i < d.Length; i++)
        {
            if(d[i] != null)
            {
                if(d[i].timer <= timer)
                {
                    Generate(d[i].name, d[i].pointX);
                    d[i] = null;
                }
            }
        }

        return d;
    }

    protected GameObject Generate(string name_, float x)
    {
        GameObject g = Instantiate(Resources.Load(name_) as GameObject);
        g.transform.position = new Vector3(g.transform.position.x, g.transform.position.y, g.transform.position.z);
        return g;
    }

    protected bool IsAllDead(GenerateData[] d)
    {
        int cnt = 0;
        foreach (var i in d)
            if (i != null)
                cnt++;

        return cnt == 0;
    }
}

[System.Serializable]
public class GenerateData
{
    public string name;
    public float pointX;
    public float timer;
}
