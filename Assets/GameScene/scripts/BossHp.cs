using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp : MonoBehaviour
{
    public Slider Slider;
    // Start is called before the first frame update
    void Start()
    {
        Slider.value = enemyMove3.hp / enemyMove3.maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        Slider.value = (float)enemyMove3.hp / (float)enemyMove3.maxhp;
    }
}
