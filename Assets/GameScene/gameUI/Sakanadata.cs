using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sakanadata : MonoBehaviour
{
    public int target;
    Text sakana_name;
    Text sakana_torisetu;
    Text gakumei;
    RawImage sakana_gazou;
    public UIData[] DataBase;
    void Start()
    {
        sakana_name = GameObject.Find("Canvas/sakana name/Fish").GetComponent<Text>();
        sakana_torisetu = GameObject.Find("Canvas/sakana torisetu/Fishint").GetComponent<Text>();
        gakumei = GameObject.Find("Canvas/gakuname/FishWname").GetComponent<Text>();
        sakana_gazou = GameObject.Find("Canvas/sakana gazou").GetComponent<RawImage>();
    }


    // Update is called once per frame
    void Update()
    {
        if(target < 15)
        {
            sakana_name.text = "魚の名前:" + DataBase[target].name;
            sakana_torisetu.text = "解説:" + DataBase[target].discription;
            gakumei.text = "学名:" + DataBase[target].gakumei;
            sakana_gazou.texture = DataBase[target].image;
        }
    }
}
[System.Serializable]
public class UIData
{
    public Texture2D image;
    public string name;
    public string gakumei;
    [Multiline(7)]
    public string discription;
}
