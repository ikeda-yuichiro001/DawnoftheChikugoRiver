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
            case 0: fishT.text = "魚"; break;
            case 1: fishT.text = "ニッポンバラタナゴ"; break;
            case 2: fishT.text = "オヤニラミ"; break;
            case 3: fishT.text = "二ホンウナギ"; break;
            case 4: fishT.text = "ドンコ"; break;
            case 5: fishT.text = "ナマズ"; break;
            case 6: fishT.text = "ヤリタナゴ"; break;
            case 7: fishT.text = "アブラボテ"; break;
        }

        switch (fishN)//学名
        {
            case 0: fishTWname.text = "fish"; break;
            case 1: fishTWname.text = "Rhodeus ocellatus kurumeus"; break;
            case 2: fishTWname.text = "Coreoperca kawamebari"; break;
            case 3: fishTWname.text = "Anguilla japonica"; break;
            case 4: fishTWname.text = "Odontobutis obscura)"; break;
            case 5: fishTWname.text = "Silurus asotus"; break;
            case 6: fishTWname.text = "Tanakia lanceolata"; break;
            case 7: fishTWname.text = "Tanakia limbata"; break;
        }

        switch (fishN)//解説 90文字ていど
        {
            case 0: fishint.text = "まだ見つけられてないよ"; break;
            case 1: fishint.text = "メスよりもオスのほうが大きく育つ" +
                    "体は銀色だが虹色の光沢が出る"; break;
            case 2: fishint.text = "魚C"; break;
            case 3: fishint.text = "魚D"; break;
            case 4: fishint.text = ""; break;
            case 5: fishint.text = ""; break;
            case 6: fishint.text = " "; break;
            case 7: fishint.text = ""; break;
        }

       /* switch (fishN)//saknagazou
        {
            case 0: fishimage.sprite = fishe[fishN]; break;
            case i: fishimage.sprite = fishe[fishN]; break;
        }*/

        if(fishN >= 0)
        {
            fishimage.sprite = fishe[fishN];
        }

    }
}
