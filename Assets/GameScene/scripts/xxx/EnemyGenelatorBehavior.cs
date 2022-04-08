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
                    Generate(d[i].name, d[i].pointX,d[i].pointZ);
                    d[i] = null;
                }
            }
        }

        return d;
    }

    protected GameObject Generate(string name_, float x, float z)
    {
        object a = Resources.Load(name_);
        if(a == null)
        {
            //Debug.Log("!?!?!?"+ name_);
        }
        GameObject g = Instantiate(a as GameObject);
        g.transform.position = new Vector3(g.transform.position.x + x, g.transform.position.y, g.transform.position.z + z);
        if(g == null)
        {
            Debug.Log("-----"+ name_);
        }

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
    public float pointZ;
    public float timer;
}
