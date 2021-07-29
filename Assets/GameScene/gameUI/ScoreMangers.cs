using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMangers : MonoBehaviour
{
    public GameObject score_object = null; //テキストオブジェクト
    public int herl;
    public int herlBit;
    public int Invincible;
    public int InvincibleBit;
    public int Boom;
    public int BoomBit;
    public int Power;
    public int RetryRemain;
    public int RetryRemainBit;

    public Text Recover;
    public Text RecoverBit;
    public Text InvincibleT;
    public Text InvincibleBitT;
    public Text BoomT;
    public Text BoomBitT;
    public Text PowerT;
    public Text RetryRemainT;
    public Text RetryRemainBitT;

    public Image[] aiconall = new Image[42];
    public Sprite[] aicon = new Sprite[10];

    // Start is called before the first frame update
    void Start()
    {
        herl = 0;
        herlBit = 0;
        Invincible = 0;
        InvincibleBit = 0;
        Boom = 0;
        BoomBit = 0;
        Power = 0;
        RetryRemain = 3;
        RetryRemainBit = 0;

        Debug.Log(gameObject.name);
        /*Recover = GameObject.Find("Canvas/Recover").GetComponent<Text>();
        Invincible = GameObject.Find("Canvas/Invincible").GetComponent<Text>();
        RetryRemain = GameObject.Find("Canvas/RetryRemain").GetComponent<Text>();
        RetryRemainBit = GameObject.Find("Canvas/RetryRemainBit").GetComponent<Text>();
        Boom = GameObject.Find("Canvas/Boom").GetComponent<Text>();
        BoomBit = GameObject.Find("Canvas/BoomBit").GetComponent<Text>();
        Power = GameObject.Find("Canvas/Power").GetComponent<Text>();*/

    }

    // Update is called once per frame
    void Update()
    {
        //オブジェクトからテキストコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();

        //
        switch (herl)//回復
        {
            case 0:// Recover.text = "回復 ： ";
                aiconall[0].sprite = aicon[0];
                aiconall[1].sprite = aicon[0];
                aiconall[2].sprite = aicon[0];
                aiconall[3].sprite = aicon[0];
                aiconall[4].sprite = aicon[0];
                aiconall[5].sprite = aicon[0];
                aiconall[6].sprite = aicon[0];



                break;
            case 1: //Recover.text = "回復 ：★";
                aiconall[0].sprite = aicon[3];
                aiconall[1].sprite = aicon[0];
                aiconall[2].sprite = aicon[0];
                aiconall[3].sprite = aicon[0];
                aiconall[4].sprite = aicon[0];
                aiconall[5].sprite = aicon[0];
                aiconall[6].sprite = aicon[0];
                break;
            case 2: //Recover.text = "回復 ：★★";
                aiconall[0].sprite = aicon[3];
                aiconall[1].sprite = aicon[3];
                aiconall[2].sprite = aicon[0];
                aiconall[3].sprite = aicon[0];
                aiconall[4].sprite = aicon[0];
                aiconall[5].sprite = aicon[0];
                aiconall[6].sprite = aicon[0];
                break;
            case 3: //Recover.text = "回復 ：★★★";
                aiconall[0].sprite = aicon[3];
                aiconall[1].sprite = aicon[3];
                aiconall[2].sprite = aicon[3];
                aiconall[3].sprite = aicon[0];
                aiconall[4].sprite = aicon[0];
                aiconall[5].sprite = aicon[0];
                aiconall[6].sprite = aicon[0];
                break;
            case 4: //Recover.text = "回復 ：★★★★";
                aiconall[0].sprite = aicon[3];
                aiconall[1].sprite = aicon[3];
                aiconall[2].sprite = aicon[3];
                aiconall[3].sprite = aicon[3];
                aiconall[4].sprite = aicon[0];
                aiconall[5].sprite = aicon[0];
                aiconall[6].sprite = aicon[0];
                break;
            case 5: //Recover.text = "回復 ：★★★★★";
                aiconall[0].sprite = aicon[3];
                aiconall[1].sprite = aicon[3];
                aiconall[2].sprite = aicon[3];
                aiconall[3].sprite = aicon[3];
                aiconall[4].sprite = aicon[3];
                aiconall[5].sprite = aicon[0];
                aiconall[6].sprite = aicon[0];
                break;
            case 6: //Recover.text = "回復 ：★★★★★★";
                aiconall[0].sprite = aicon[3];
                aiconall[1].sprite = aicon[3];
                aiconall[2].sprite = aicon[3];
                aiconall[3].sprite = aicon[3];
                aiconall[4].sprite = aicon[3];
                aiconall[5].sprite = aicon[3];
                aiconall[6].sprite = aicon[0];
                break;
            case 7: //Recover.text = "回復 ：★★★★★★★";
                aiconall[0].sprite = aicon[3];
                aiconall[1].sprite = aicon[3];
                aiconall[2].sprite = aicon[3];
                aiconall[3].sprite = aicon[3];
                aiconall[4].sprite = aicon[3];
                aiconall[5].sprite = aicon[3];
                aiconall[6].sprite = aicon[3];
                break;
        }

        switch (herlBit)
        {
            case 0:// RecoverBit.text = "回復かけら ： ";
                aiconall[7].sprite = aicon[0];
                aiconall[8].sprite = aicon[0];

                break;
            case 1: //RecoverBit.text = "回復かけら ：★";
                aiconall[7].sprite = aicon[4];
                aiconall[8].sprite = aicon[0];

                break;
            case 2: //RecoverBit.text = "回復かけら ：★★";
                aiconall[7].sprite = aicon[4];
                aiconall[8].sprite = aicon[4];

                break;
                //score_text.text = ("[{2}]");
        }
        if(herlBit == 3)//かけらを重ねる
        {
            herlBit = 0;
            herl++;
        }

        switch (Boom)//爆弾
        {
            case 0: //BoomT.text = "ボム ： ";
                aiconall[16].sprite = aicon[0];
                aiconall[17].sprite = aicon[0];
                aiconall[18].sprite = aicon[0];
                aiconall[19].sprite = aicon[0];
                aiconall[20].sprite = aicon[0];
                aiconall[21].sprite = aicon[0];
                aiconall[22].sprite = aicon[0];
                break;
            case 1:// BoomT.text = "ボム ：★";
                aiconall[16].sprite = aicon[1];
                aiconall[17].sprite = aicon[0];
                aiconall[18].sprite = aicon[0];
                aiconall[19].sprite = aicon[0];
                aiconall[20].sprite = aicon[0];
                aiconall[21].sprite = aicon[0];
                aiconall[22].sprite = aicon[0];
                break;
            case 2:// BoomT.text = "ボム ：★★";
                aiconall[16].sprite = aicon[1];
                aiconall[17].sprite = aicon[1];
                aiconall[18].sprite = aicon[0];
                aiconall[19].sprite = aicon[0];
                aiconall[20].sprite = aicon[0];
                aiconall[21].sprite = aicon[0];
                aiconall[22].sprite = aicon[0];
                break;
            case 3:// BoomT.text = "ボム ：★★★";
                aiconall[16].sprite = aicon[1];
                aiconall[17].sprite = aicon[1];
                aiconall[18].sprite = aicon[1];
                aiconall[19].sprite = aicon[0];
                aiconall[20].sprite = aicon[0];
                aiconall[21].sprite = aicon[0];
                aiconall[22].sprite = aicon[0];
                break;
            case 4:// BoomT.text = "ボム ：★★★★";
                aiconall[16].sprite = aicon[1];
                aiconall[17].sprite = aicon[1];
                aiconall[18].sprite = aicon[1];
                aiconall[19].sprite = aicon[1];
                aiconall[20].sprite = aicon[0];
                aiconall[21].sprite = aicon[0];
                aiconall[22].sprite = aicon[0];
                break;
            case 5:// BoomT.text = "ボム ：★★★★★";
                aiconall[16].sprite = aicon[1];
                aiconall[17].sprite = aicon[1];
                aiconall[18].sprite = aicon[1];
                aiconall[19].sprite = aicon[1];
                aiconall[20].sprite = aicon[1];
                aiconall[21].sprite = aicon[0];
                aiconall[22].sprite = aicon[0];
                break;
            case 6:// BoomT.text = "ボム ：★★★★★★";
                aiconall[16].sprite = aicon[1];
                aiconall[17].sprite = aicon[1];
                aiconall[18].sprite = aicon[1];
                aiconall[19].sprite = aicon[1];
                aiconall[20].sprite = aicon[1];
                aiconall[21].sprite = aicon[1];
                aiconall[22].sprite = aicon[0];
                break;
            case 7:// BoomT.text = "ボム ：★★★★★★★";
                aiconall[16].sprite = aicon[1];
                aiconall[17].sprite = aicon[1];
                aiconall[18].sprite = aicon[1];
                aiconall[19].sprite = aicon[1];
                aiconall[20].sprite = aicon[1];
                aiconall[21].sprite = aicon[1];
                aiconall[22].sprite = aicon[1];
                break;
        }

        switch (BoomBit)
        {
            case 0:// BoomBitT.text = "ボムかけら ： ";
                aiconall[23].sprite = aicon[0];
                aiconall[24].sprite = aicon[0]; 
                break;
            case 1:// BoomBitT.text = "ボムかけら ：★";
                aiconall[23].sprite = aicon[2];
                aiconall[24].sprite = aicon[0]; 
                break;
            case 2:// BoomBitT.text = "ボムかけら ：★★";
                aiconall[23].sprite = aicon[2];
                aiconall[24].sprite = aicon[2]; 
                break;
                //score_text.text = ("[{2}]");
        }
        if (BoomBit == 3)//かけらを重ねる
        {
            BoomBit = 0;
            Boom++;
        }

        switch (Invincible)//無敵
        {
            case 0:// InvincibleT.text = "無敵 ： ";
                aiconall[9].sprite = aicon[0];
                aiconall[10].sprite = aicon[0];
                aiconall[11].sprite = aicon[0];
                aiconall[12].sprite = aicon[0];
                aiconall[13].sprite = aicon[0];
                aiconall[14].sprite = aicon[0];
                aiconall[15].sprite = aicon[0];
                break;
            case 1:// InvincibleT.text = "無敵 ：★";
                aiconall[9].sprite = aicon[5];
                aiconall[10].sprite = aicon[0];
                aiconall[11].sprite = aicon[0];
                aiconall[12].sprite = aicon[0];
                aiconall[13].sprite = aicon[0];
                aiconall[14].sprite = aicon[0];
                aiconall[15].sprite = aicon[0]; 
                break;
            case 2:// InvincibleT.text = "無敵 ：★★";
                aiconall[9].sprite = aicon[5];
                aiconall[10].sprite = aicon[5];
                aiconall[11].sprite = aicon[0];
                aiconall[12].sprite = aicon[0];
                aiconall[13].sprite = aicon[0];
                aiconall[14].sprite = aicon[0];
                aiconall[15].sprite = aicon[0]; 
                break;
            case 3:// InvincibleT.text = "無敵 ：★★★";
                aiconall[9].sprite = aicon[5];
                aiconall[10].sprite = aicon[5];
                aiconall[11].sprite = aicon[5];
                aiconall[12].sprite = aicon[0];
                aiconall[13].sprite = aicon[0];
                aiconall[14].sprite = aicon[0];
                aiconall[15].sprite = aicon[0]; 
                break;
            case 4:// InvincibleT.text = "無敵 ：★★★★";
                aiconall[9].sprite = aicon[5];
                aiconall[10].sprite = aicon[5];
                aiconall[11].sprite = aicon[5];
                aiconall[12].sprite = aicon[5];
                aiconall[13].sprite = aicon[0];
                aiconall[14].sprite = aicon[0];
                aiconall[15].sprite = aicon[0]; 
                break;
            case 5:// InvincibleT.text = "無敵 ：★★★★★";
                aiconall[9].sprite = aicon[5];
                aiconall[10].sprite = aicon[5];
                aiconall[11].sprite = aicon[5];
                aiconall[12].sprite = aicon[5];
                aiconall[13].sprite = aicon[5];
                aiconall[14].sprite = aicon[0];
                aiconall[15].sprite = aicon[0]; 
                break;
            case 6:// InvincibleT.text = "無敵 ：★★★★★★";
                aiconall[9].sprite = aicon[5];
                aiconall[10].sprite = aicon[5];
                aiconall[11].sprite = aicon[5];
                aiconall[12].sprite = aicon[5];
                aiconall[13].sprite = aicon[5];
                aiconall[14].sprite = aicon[5];
                aiconall[15].sprite = aicon[0]; 
                break;
            case 7:// InvincibleT.text = "無敵 ：★★★★★★★";
                aiconall[9].sprite = aicon[5];
                aiconall[10].sprite = aicon[5];
                aiconall[11].sprite = aicon[5];
                aiconall[12].sprite = aicon[5];
                aiconall[13].sprite = aicon[5];
                aiconall[14].sprite = aicon[5];
                aiconall[15].sprite = aicon[5]; 
                break;
        }

        /*switch (InvincibleBit)
        {
            case 0: InvincibleBitT.text = "無敵かけら ： "; break;
            case 1: InvincibleBitT.text = "無敵かけら ：★"; break;
            case 2: InvincibleBitT.text = "無敵かけら ：★★"; break;
                //score_text.text = ("[{2}]");
        }
        if (InvincibleBit == 3)//かけらを重ねる
        {
            InvincibleBit = 0;
            Invincible++;
        }*/

        switch (Power)//ちから
        {
            case 0:// PowerT.text = "ちから ： ";
                aiconall[34].sprite = aicon[0];
                aiconall[35].sprite = aicon[0];
                aiconall[36].sprite = aicon[0];
                aiconall[37].sprite = aicon[0];
                aiconall[38].sprite = aicon[0];
                aiconall[39].sprite = aicon[0];
                aiconall[40].sprite = aicon[0];
                break;
            case 1:// PowerT.text = "ちから ：★";
                aiconall[34].sprite = aicon[7];
                aiconall[35].sprite = aicon[0];
                aiconall[36].sprite = aicon[0];
                aiconall[37].sprite = aicon[0];
                aiconall[38].sprite = aicon[0];
                aiconall[39].sprite = aicon[0];
                aiconall[40].sprite = aicon[0];
                break;
            case 2:// PowerT.text = "ちから ：★★";
                aiconall[34].sprite = aicon[7];
                aiconall[35].sprite = aicon[7];
                aiconall[36].sprite = aicon[0];
                aiconall[37].sprite = aicon[0];
                aiconall[38].sprite = aicon[0];
                aiconall[39].sprite = aicon[0];
                aiconall[40].sprite = aicon[0];
                break;
            case 3:// PowerT.text = "ちから ：★★★";
                aiconall[34].sprite = aicon[7];
                aiconall[35].sprite = aicon[7];
                aiconall[36].sprite = aicon[7];
                aiconall[37].sprite = aicon[0];
                aiconall[38].sprite = aicon[0];
                aiconall[39].sprite = aicon[0];
                aiconall[40].sprite = aicon[0];
                break;
            case 4:// PowerT.text = "ちから ：★★★★";
                aiconall[34].sprite = aicon[7];
                aiconall[35].sprite = aicon[7];
                aiconall[36].sprite = aicon[7];
                aiconall[37].sprite = aicon[7];
                aiconall[38].sprite = aicon[0];
                aiconall[39].sprite = aicon[0];
                aiconall[40].sprite = aicon[0];
                break;
            case 5:// PowerT.text = "ちから ：★★★★★";
                aiconall[34].sprite = aicon[7];
                aiconall[35].sprite = aicon[7];
                aiconall[36].sprite = aicon[7];
                aiconall[37].sprite = aicon[7];
                aiconall[38].sprite = aicon[7];
                aiconall[39].sprite = aicon[0];
                aiconall[40].sprite = aicon[0];
                break;
            case 6:// PowerT.text = "ちから ：★★★★★★";
                aiconall[34].sprite = aicon[7];
                aiconall[35].sprite = aicon[7];
                aiconall[36].sprite = aicon[7];
                aiconall[37].sprite = aicon[7];
                aiconall[38].sprite = aicon[7];
                aiconall[39].sprite = aicon[7];
                aiconall[40].sprite = aicon[0];

                break;
            case 7:// PowerT.text = "ちから ：★★★★★★★";
                aiconall[34].sprite = aicon[7];
                aiconall[35].sprite = aicon[7];
                aiconall[36].sprite = aicon[7];
                aiconall[37].sprite = aicon[7];
                aiconall[38].sprite = aicon[7];
                aiconall[39].sprite = aicon[7];
                aiconall[40].sprite = aicon[7];
                break;
        }

        switch (RetryRemain)//回復
        {
            case 0:// RetryRemainT.text = "残基 ： ";
                aiconall[25].sprite = aicon[0];
                aiconall[26].sprite = aicon[0];
                aiconall[27].sprite = aicon[0];
                aiconall[28].sprite = aicon[0];
                aiconall[29].sprite = aicon[0];
                aiconall[30].sprite = aicon[0];
                aiconall[31].sprite = aicon[0];
                break;
            case 1:// RetryRemainT.text = "残基 ：★";
                aiconall[25].sprite = aicon[6];
                aiconall[26].sprite = aicon[0];
                aiconall[27].sprite = aicon[0];
                aiconall[28].sprite = aicon[0];
                aiconall[29].sprite = aicon[0];
                aiconall[30].sprite = aicon[0];
                aiconall[31].sprite = aicon[0];
                break;
            case 2:// RetryRemainT.text = "残基 ：★★";
                aiconall[25].sprite = aicon[6];
                aiconall[26].sprite = aicon[6];
                aiconall[27].sprite = aicon[0];
                aiconall[28].sprite = aicon[0];
                aiconall[29].sprite = aicon[0];
                aiconall[30].sprite = aicon[0];
                aiconall[31].sprite = aicon[0];
                break;
            case 3:// RetryRemainT.text = "残基 ：★★★";
                aiconall[25].sprite = aicon[6];
                aiconall[26].sprite = aicon[6];
                aiconall[27].sprite = aicon[6];
                aiconall[28].sprite = aicon[0];
                aiconall[29].sprite = aicon[0];
                aiconall[30].sprite = aicon[0];
                aiconall[31].sprite = aicon[0];
                break;
            case 4:// RetryRemainT.text = "残基 ：★★★★";
                aiconall[25].sprite = aicon[6];
                aiconall[26].sprite = aicon[6];
                aiconall[27].sprite = aicon[6];
                aiconall[28].sprite = aicon[6];
                aiconall[29].sprite = aicon[0];
                aiconall[30].sprite = aicon[0];
                aiconall[31].sprite = aicon[0];
                break;
            case 5:// RetryRemainT.text = "残基 ：★★★★★";
                aiconall[25].sprite = aicon[6];
                aiconall[26].sprite = aicon[6];
                aiconall[27].sprite = aicon[6];
                aiconall[28].sprite = aicon[6];
                aiconall[29].sprite = aicon[6];
                aiconall[30].sprite = aicon[0];
                aiconall[31].sprite = aicon[0];
                break;
            case 6:// RetryRemainT.text = "残基 ：★★★★★★";
                aiconall[25].sprite = aicon[6];
                aiconall[26].sprite = aicon[6];
                aiconall[27].sprite = aicon[6];
                aiconall[28].sprite = aicon[6];
                aiconall[29].sprite = aicon[6];
                aiconall[30].sprite = aicon[6];
                aiconall[31].sprite = aicon[0];
                break;
            case 7:// RetryRemainT.text = "残基 ：★★★★★★★";
                aiconall[25].sprite = aicon[6];
                aiconall[26].sprite = aicon[6];
                aiconall[27].sprite = aicon[6];
                aiconall[28].sprite = aicon[6];
                aiconall[29].sprite = aicon[6];
                aiconall[30].sprite = aicon[6];
                aiconall[31].sprite = aicon[6];
                break;
        }

        switch (RetryRemainBit)
        {
            case 0:// RetryRemainBitT.text = "残基かけら ： "; 
                aiconall[32].sprite = aicon[0];
                aiconall[33].sprite = aicon[0];
                break;
            case 1:// RetryRemainBitT.text = "残基かけら ：★";
                aiconall[32].sprite = aicon[8];
                aiconall[33].sprite = aicon[0];
                break;
            case 2:// RetryRemainBitT.text = "残基かけら ：★★";
                aiconall[32].sprite = aicon[8];
                aiconall[33].sprite = aicon[8];
                break;
                //score_text.text = ("[{2}]");
        }
        if (RetryRemainBit == 3)//かけらを重ねる
        {
            RetryRemainBit = 0;
            RetryRemain++;

        }
        /////

    }
}
