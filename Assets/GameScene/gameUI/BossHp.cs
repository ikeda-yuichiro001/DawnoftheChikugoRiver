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
        Slider.value = enemymove3.hp / enemymove3.maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        Slider.value = (float)enemymove3.hp / (float)enemymove3.maxhp;
    }
}
