using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp : MonoBehaviour
{
    public Slider Slider;
    public GameObject boss1;
    public GameObject boss2;
    public GameObject boss3;
    public GameObject boss4;
    public GameObject boss5;
    // Start is called before the first frame update
    void Start()
    {
        boss1 = GameObject.Find("kurumeusu");
        boss2 = GameObject.Find("kuru");//karioki
        boss3 = GameObject.Find("kurume");//karioki
        boss4 = GameObject.Find("kurumeu");//karioki
        boss5 = GameObject.Find("ku");//karioki

        if (boss1 != null)
        {
            Slider.value = boss1.GetComponent<EnemyMove>().hp / boss1.GetComponent<EnemyMove>().maxhp;
        }
        if (boss2 != null)
        {
            Slider.value = boss2.GetComponent<EnemyMove>().hp / boss2.GetComponent<EnemyMove>().maxhp;
        }
        if (boss3 != null)
        {
            Slider.value = boss3.GetComponent<EnemyMove>().hp / boss3.GetComponent<EnemyMove>().maxhp;
        }
        if (boss4 != null)
        {
            Slider.value = boss4.GetComponent<EnemyMove>().hp / boss4.GetComponent<EnemyMove>().maxhp;
        }
        if (boss5 != null)
        {
            Slider.value = boss5.GetComponent<EnemyMove>().hp / boss5.GetComponent<EnemyMove>().maxhp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (boss1 != null)
        {
            Slider.value = (float)boss1.GetComponent<EnemyMove>().hp / (float)boss1.GetComponent<EnemyMove>().maxhp;
        }
        if (boss2 != null)
        {
            Slider.value = (float)boss2.GetComponent<EnemyMove>().hp / (float)boss2.GetComponent<EnemyMove>().maxhp;
        }
        if (boss3 != null)
        {
            Slider.value = (float)boss3.GetComponent<EnemyMove>().hp / (float)boss3.GetComponent<EnemyMove>().maxhp;
        }
        if (boss4 != null)
        {
            Slider.value = (float)boss4.GetComponent<EnemyMove>().hp / (float)boss4.GetComponent<EnemyMove>().maxhp;
        }
        if (boss5 != null)
        {
            Slider.value = (float)boss5.GetComponent<EnemyMove>().hp / (float)boss5.GetComponent<EnemyMove>().maxhp;
        }
    }
}
