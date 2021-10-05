using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sakanadata : MonoBehaviour
{
    public static int target;
    public static float cunt;
    Text sakana_name;
    Text sakana_torisetu;
    RawImage sakana_gazou;
    public UIData[] DataBase;
    void Start()
    {
        sakana_name = GameObject.Find("Canvas/sakana name/Fish").GetComponent<Text>();
        sakana_torisetu = GameObject.Find("Canvas/sakana torisetu/Fishint").GetComponent<Text>();
        sakana_gazou = GameObject.Find("Canvas/sakana gazou").GetComponent<RawImage>();
        target = 0;
    }


    // Update is called once per frame
    void Update()
    {
        cunt += 1 * Time.deltaTime; Debug.Log(cunt);
        if (target < 16)
        {
            sakana_name.text = "魚の名前:" + DataBase[target].name;
            sakana_torisetu.text = "解説:" + DataBase[target].discription;
            sakana_gazou.texture = DataBase[target].image;
        }
    }
}
[System.Serializable]
public class UIData
{
    public Texture2D image;
    public string name;
    [Multiline(7)]
    public string discription;
}
