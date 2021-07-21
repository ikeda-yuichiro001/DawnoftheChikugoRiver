using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fishall : MonoBehaviour
{
    public GameObject FishAll = null; //テキストオブジェクト
    public int fishN; //魚の割り当て


    public Text fishT;　　　　//名前
    public Text fishTWname;　// 学名
    public Text fishint;   //解説　解説も画像で取り込ました法がいいのではないか
    public Sprite[] fishe = new Sprite[10];//魚画像
    public Image fishimage;


    // Start is called before the first frame update
    void Start()
    {

        fishN = 0;//０はブランクとして置いておく

    }

    // Update is called once per frame
    void Update()
    {
        //魚を倒したら　x=1 A魚　=2 Ｂ魚　を代入でどうにか

        switch (fishN)//名前
        {
            case 0: fishT.text = "魚A"; break;
            case 1: fishT.text = "魚B"; break;
            case 2: fishT.text = "魚C"; break;
            case 3: fishT.text = "魚D"; break;
            case 4: fishT.text = "魚E"; break;
            case 5: fishT.text = "魚F"; break;
            case 6: fishT.text = "魚G"; break;
            case 7: fishT.text = "魚H"; break;
        }

        switch (fishN)//学名
        {
            case 0: fishTWname.text = "魚A"; break;
            case 1: fishTWname.text = "魚B"; break;
            case 2: fishTWname.text = "魚C"; break;
            case 3: fishTWname.text = "魚D"; break;
            case 4: fishTWname.text = "魚E"; break;
            case 5: fishTWname.text = "魚F"; break;
            case 6: fishTWname.text = "魚G"; break;
            case 7: fishTWname.text = "魚H"; break;
        }

        switch (fishN)//解説
        {
            case 0: fishint.text = "あごの鋭いトゲでほかの小さな魚を捕まえて食べる筑後川の下流のほうで生息している"; break;
            case 1: fishint.text = "魚B"; break;
            case 2: fishint.text = "魚C"; break;
            case 3: fishint.text = "魚D"; break;
            case 4: fishint.text = "魚E"; break;
            case 5: fishint.text = "魚F"; break;
            case 6: fishint.text = "魚G"; break;
            case 7: fishint.text = "魚H"; break;
        }

       /* switch (fishN)//saknagazou
        {
            case 0: fishimage.sprite = fishe[fishN]; break;
            case i: fishimage.sprite = fishe[fishN]; break;
        }*/

        if(fishN >= -1)
        {
            fishimage.sprite = fishe[fishN];
        }

    }
}
