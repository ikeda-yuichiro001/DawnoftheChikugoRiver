using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public int i = 1;//どの弾幕を撃つのかの設定
    public bool mirror;//反対に移動するときとかに使って
    int MirrorDirection = 1;
    int w = 0, a = 0;
    public int hp; //インスペクター上で設定して
    public int maxhp;//これも
    public static int bossHp = 1;
    float cnt;
    public int t;//全方位弾幕xwayに撃つ
    public float Speed;//弾の連射速度の設定
    public float PlacementDistance;//2つ撃たれた時の弾の間隔をここで取る
    GameObject Player;
    float d = 100;//弾と自機の距離はここで取る。－＞被弾判定に使う
    //float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("player");
        if(i == 9)
        StartCoroutine("uzumaki");
    }

    // Update is called once per frame
    void Update()
    {
        //t += Time.deltaTime;
        switch (i)
        {
            case 1:
                enemymove1();
                //i++;
                break;

            case 2:
                enemymove2();
                //i++;
                break;

            case 3:
                enemymove3();
                //i++;
                break;

            case 4:
                enemymove4();
                //i++;
                break;

            case 5:
                enemymove5();
                //i++;
                break;

            case 6:
                enemymove6();
                //i++;
                break;

            case 7:
                enemymove7();
                //i++;
                break;

            case 8:
                enemymove8();
                //i++;
                break;

            case 9:
                enemymove9();
                //i++;
                break;

            case 10:
                enemymove10();
                //i++;
                break;

            case 11:
                enemymove11();
                //i++;
                break;

            case 12:
                enemymove12();
                //i++;
                break;

            case 13:
                enemymove13();
                //i++;
                break;

            case 14:
                enemymove14();
                //i++;
                break;

            case 15:
                enemymove15();
                //i = 1;
                break;
            default:
                break;
        }
    }
    //下に一発
    void enemymove1() {
        
    MirrorDirection = 1;
    if (mirror) MirrorDirection = -1;

    cnt += Time.deltaTime * Speed * DifficultyScene.difspd * DifficultyScene.difspd * 0.2f;                        //new
    if (cnt >= 1)                                  //new
    {
        GameObject aa = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
        aa.GetComponent<enemyShotPattern>().arrow = new Vector2(0, -DifficultyScene.difspd * 0.3f);
        cnt = 0;
    }

    GetComponent<Rigidbody>().position += new Vector3(-0.1f * MirrorDirection, 0, 0);

        if (transform.position.x < -40)
            Destroy(gameObject);
        if (transform.position.x > 40)
            Destroy(gameObject);

        if (hp <= 0)
    {

        while (w < 50)
        {
                //Debug.Log(a);
                //Debug.Log(w);

            if (a % 2 == 0)
            {
                Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
            }
            else
            {
                Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
            }
            a = Random.Range(0, 99);
            w = Random.Range(0, 99);
        }

        imageTest.kari += 100;
        imageTest.scorejudge = 1;
        Destroy(gameObject);
    }

    if (Player != null)
    {
        d = Vector3.Distance(transform.position, Player.transform.position);
    }

    if (d < 2.5f)
    {
        if(Player != null)
        shot.PowData = Player.gameObject.GetComponent<shot>().Power;
        Destroy(Player);
        Debug.Log("ピチューン！");
    }
}
    //下に二発
    void enemymove2()
    {

        MirrorDirection = 1;
        if (mirror) MirrorDirection = -1;

        cnt += Time.deltaTime * Speed * DifficultyScene.difspd * DifficultyScene.difspd * 0.2f;                        //new
        if (cnt >= 1)                                  //new
        {
            GameObject a2 = Instantiate(Resources.Load("enemy_bul"), new Vector3(transform.position.x + PlacementDistance, transform.position.y, transform.position.z), Quaternion.identity) as GameObject; //new
            GameObject aa2 = Instantiate(Resources.Load("enemy_bul"), new Vector3(transform.position.x - PlacementDistance, transform.position.y, transform.position.z), Quaternion.identity) as GameObject; //new
            a2.GetComponent<enemyShotPattern>().arrow = new Vector2(0, -DifficultyScene.difspd * 0.3f);
            aa2.GetComponent<enemyShotPattern>().arrow = new Vector2(0, -DifficultyScene.difspd * 0.3f);
            cnt = 0;
        }

        GetComponent<Rigidbody>().position += new Vector3(-0.1f * MirrorDirection, 0, 0);

        if (transform.position.x < -40) Destroy(gameObject);
        if (transform.position.x > 40) Destroy(gameObject);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            imageTest.kari += 100;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
        }

        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
        }
    }
    //下にnway敵機依存弾幕e3n5h7l9 stage1boss
    void enemymove3()
    {
        cnt += Time.deltaTime * DifficultyScene.difspd * DifficultyScene.difspd * 0.1f * Speed;                        //new
        if (cnt >= 1)                                  //new
        {
            for (int v = 0; v < 2 * DifficultyScene.difspd + 1; v++)
            {
                GameObject a3 = Instantiate(Resources.Load("kani2"), transform.position, Quaternion.Euler(0,180,0)) as GameObject; //new
                if (v % 2 == 0)
                {
                    a3.GetComponent<enemyShotPattern2>().arrow = new Vector2(Mathf.Sin(v/2 * 1f / Mathf.PI * 2), -Mathf.Cos(v/2 * 1f / Mathf.PI * 2)) * DifficultyScene.difspd * Speed  / 15;
                }
                else
                {
                    a3.GetComponent<enemyShotPattern2>().arrow = new Vector2(Mathf.Sin(-(v/2+1) * 1f / Mathf.PI * 2), -Mathf.Cos(-(v/2+1) * 1f / Mathf.PI * 2)) * DifficultyScene.difspd * Speed  / 15;
                }
                //
            }
            cnt = 0;
        }
        GetComponent<Rigidbody>().position += new Vector3(Mathf.Cos(Time.time * 3), 0, 0);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            imageTest.kari += 100;
            imageTest.scorejudge = 1;
            bossHp = 0;
            Destroy(gameObject);
        }
        //ここを画面外から見えなくなったらにする
        if (transform.position.z < -player_ctrl.zlimit)
            Destroy(gameObject);
        if (transform.position.z > player_ctrl.zlimit)
            Destroy(gameObject);


        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            if(Player != null)
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
        }
    }
    //自機狙い
    void enemymove4()
    {
        bool start = false;
        if (hp!=maxhp&&!start)
        {
            hp = maxhp;
            start = true;
        }
        

        if (player_ctrl.pc != null)
            Player = player_ctrl.pc.gameObject;

        //GetComponent<Rigidbody>().position += new Vector3(Mathf.Sin(Time.time * Random.Range(2, 4))/*+0.1f*/, 0, /*Mathf.Cos(Time.time*4)*-1*/0);
        cnt += Time.deltaTime * Speed * DifficultyScene.difspd * DifficultyScene.difspd * 0.1f;

        if (cnt >= 1)                                  //new
        {
            Vector3 jikinerai = Player.transform.position - transform.position;
            jikinerai.Normalize();

            GameObject a4 = Instantiate(Resources.Load("enemy_bul_big"), transform.position, Quaternion.identity) as GameObject;
            a4.GetComponent<enemyShotPattern>().arrow = new Vector2(jikinerai.x, jikinerai.z) * DifficultyScene.difspd * 0.4f;
            //Debug.Log(a.GetComponent<enemyShotPattern>().arrow = new Vector2(jikinerai.x, jikinerai.z));
            cnt = 0;
        }

        if (transform.position.z > 35 || transform.position.z < -35 || transform.position.x > 35 || transform.position.x < -35)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
            //Debug.Log(hp);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            Destroy(gameObject);
        }

        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
        }
        
    }

    void enemymove5()//要修正
    {
        bool start = false;
        if (hp != maxhp && !start)
        {
            hp = maxhp;
            start = true;
        }
        GameObject lockon = GameObject.Find("jikinerai");
        if(Player != null)
        lockon.transform.LookAt(Player.transform);

        if (player_ctrl.pc != null)
            Player = player_ctrl.pc.gameObject;

        //GetComponent<Rigidbody>().position += new Vector3(Mathf.Sin(Time.time)/*+0.1f*/, 0, /*Mathf.Cos(Time.time*4)*-1*/0);
        cnt += Time.deltaTime * Speed * DifficultyScene.difspd * DifficultyScene.difspd * 0.1f;

        if (cnt >= 1)                                  //new
        {
            //Vector3 jikinerai = Player.transform.position - transform.position;
            //jikinerai.Normalize();

            for (int v = 0; v < 2 * DifficultyScene.difspd + 1; v++)
            {
                GameObject a5 = Instantiate(Resources.Load("enemy_bul_big"), new Vector3(transform.position.x,transform.position.y,transform.position.z-3), Quaternion.Euler(lockon.transform.rotation.x, lockon.transform.rotation.y, lockon.transform.rotation.z)) as GameObject;
                if (v % 2 == 0) {
                    //a3.GetComponent<enemyShotPattern2>().arrow = new Vector2(Mathf.Sin(v/2 * 1f / Mathf.PI * 2), -Mathf.Cos(v/2 * 1f / Mathf.PI * 2)) * DifficultyScene.difspd * Speed  / 15;
                    a5.GetComponent<enemyShotPattern2>().arrow = new Vector2(Mathf.Sin(v / 2 * 1f / Mathf.PI * 2) /* jikinerai.x*/, -Mathf.Cos(v / 2 * 1f / Mathf.PI * 2) /* jikinerai.z*/) * DifficultyScene.difspd * 0.4f;
                    a5.transform.LookAt(Player.transform);
                    //Debug.Log(a.GetComponent<enemyShotPattern>().arrow = new Vector2(jikinerai.x, jikinerai.z));
                }
                else
                {
                    //a5.GetComponent<enemyShotPattern2>().arrow = new Vector2(Mathf.Sin(-(v/2+1) * 1f / Mathf.PI * 2), -Mathf.Cos(-(v/2+1) * 1f / Mathf.PI * 2)) * DifficultyScene.difspd * Speed  / 15;
                    a5.GetComponent<enemyShotPattern2>().arrow = new Vector2(Mathf.Sin(-(v / 2 + 1) * 1f / Mathf.PI * 2) /* jikinerai.x*/, -Mathf.Cos(-(v / 2 + 1) * 1f / Mathf.PI * 2) /* jikinerai.z*/) * DifficultyScene.difspd * 0.4f;
                    a5.transform.LookAt(Player.transform);
                }
            }
                cnt = 0;
        }

        if (transform.position.z > 35 || transform.position.z < -35 || transform.position.x > 35 || transform.position.x < -35)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        //Debug.Log(hp);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            Destroy(gameObject);
        }

        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            if(Player != null)
                shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
        }

    }
    void enemymove6()
    {

    }
    //全方位
    void enemymove7()
    {
        if (mirror) MirrorDirection = -1;

        cnt += Time.deltaTime * DifficultyScene.difspd * DifficultyScene.difspd * 0.1f * Speed;                        //new
        if (cnt >= 1)                                  //new
        {
            for (int v = 0; v < t * DifficultyScene.difspd; v++)
            {
                GameObject a7 = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
                a7.GetComponent<enemyShotPattern>().arrow = new Vector2(Mathf.Sin(v * 1f / t * Mathf.PI * 2), Mathf.Cos(v * 1f / t * Mathf.PI * 2)) * DifficultyScene.difspd * Speed / 15;
            }
            cnt = 0;
        }
        GetComponent<Rigidbody>().position += new Vector3(0, 0, -0.15f * MirrorDirection);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            imageTest.kari += 100;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
        }
        //ここを画面外から見えなくなったらにする
        //if (transform.position.z < -(player_ctrl.zlimit + 10))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, player_ctrl.zlimit + 10);
        //}
        //if (transform.position.z > player_ctrl.zlimit + 10)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, -(player_ctrl.zlimit + 10));
        //}


        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
        }

    }
    //全方位＊2
    void enemymove8()
    {
        if (mirror) MirrorDirection = -1;

        cnt += Time.deltaTime * DifficultyScene.difspd * DifficultyScene.difspd * 0.1f * Speed;                        //new
        if (cnt >= 1)                                  //new
        {
            for (int v = 0; v < t * 2 * DifficultyScene.difspd; v++)
            {
                GameObject a7 = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
                a7.GetComponent<enemyShotPattern>().arrow = new Vector2(Mathf.Sin(v * 0.5f / t * Mathf.PI * 2), Mathf.Cos(v* 0.5f / t * Mathf.PI * 2)) * DifficultyScene.difspd * Speed / 15;
            }
            cnt = 0;
        }
        GetComponent<Rigidbody>().position += new Vector3(0, 0, -0.15f * MirrorDirection);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            imageTest.kari += 100;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
        }
        //ここを画面外から見えなくなったらにする
        //if (transform.position.z < -(player_ctrl.zlimit + 10))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, player_ctrl.zlimit + 10);
        //}
        //if (transform.position.z > player_ctrl.zlimit + 10)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, -(player_ctrl.zlimit + 10));
        //}


        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
        }
    }
    //渦巻き
    void enemymove9()
    {
        if (mirror) MirrorDirection = -1;

        IEnumerator uzumaki()
        {
            for (int v = 0; v < t * 2 * DifficultyScene.difspd; v++)
            {
                GameObject a7 = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
                a7.GetComponent<enemyShotPattern>().arrow = new Vector2(Mathf.Sin(v * 0.5f / t * Mathf.PI * 2), Mathf.Cos(v * 0.5f / t * Mathf.PI * 2)) * DifficultyScene.difspd * Speed / 15;

                yield return new WaitForSeconds(0.6f / DifficultyScene.difspd);
            }
        }

        cnt += Time.deltaTime * DifficultyScene.difspd * DifficultyScene.difspd * 0.1f * Speed;                        //new
        if (cnt <= 1)                                  //new
        {
            //    for (int v = 0; v < t * 2 * DifficultyScene.difspd; v++)
            //    {
            //        GameObject a7 = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
            //        a7.GetComponent<enemyShotPattern>().arrow = new Vector2(Mathf.Sin(v * 0.5f / t * Mathf.PI * 2), Mathf.Cos(v * 0.5f / t * Mathf.PI * 2)) * DifficultyScene.difspd * Speed / 15;

            //    }
            uzumaki();
            cnt = 0;
        }

        //GetComponent<Rigidbody>().position += new Vector3(0, 0, -0.15f * MirrorDirection);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            imageTest.kari += 100;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
        }
        //ここを画面外から見えなくなったらにする
        //if (transform.position.z < -(player_ctrl.zlimit + 10))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, player_ctrl.zlimit + 10);
        //}
        //if (transform.position.z > player_ctrl.zlimit + 10)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, -(player_ctrl.zlimit + 10));
        //}


        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            if(Player != null)
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
        }
    }
    IEnumerator uzumaki()
    {
        for (int v = 0; v < t * 16 * DifficultyScene.difspd; v++)
        {
            GameObject a7 = Instantiate(Resources.Load("enemy_bul"), transform.position, Quaternion.identity) as GameObject; //new
            a7.GetComponent<enemyShotPattern>().arrow = new Vector2(Mathf.Sin((v * 1f / 16) / t * Mathf.PI * 2), Mathf.Cos((v * 1f / 16) / t * Mathf.PI * 2)) * DifficultyScene.difspd * Speed / 30;

            yield return new WaitForSeconds(0.05f / DifficultyScene.difspd);
            if (v == t * 16 * DifficultyScene.difspd - 1) v = -1;
        }
    }
    //dualwave
    void enemymove10()
    {
        MirrorDirection = 1;
        if (mirror) MirrorDirection = -1;
        float PlacementDistances = 20 ;

        cnt += Time.deltaTime * Speed * DifficultyScene.difspd * DifficultyScene.difspd * 0.5f;                        //new
        if (cnt >= 1)                                  //new
        {
            GameObject a2 = Instantiate(Resources.Load("enemy_bul"), new Vector3(transform.position.x +PlacementDistances * Mathf.Sin(Time.time), transform.position.y, transform.position.z), Quaternion.identity) as GameObject; //new
            GameObject aa2 = Instantiate(Resources.Load("enemy_bul"), new Vector3(transform.position.x -PlacementDistances  * Mathf.Sin(Time.time), transform.position.y, transform.position.z), Quaternion.identity) as GameObject; //new
            a2.GetComponent<enemyShotPattern>().arrow = new Vector2(0, -DifficultyScene.difspd * 0.3f);
            aa2.GetComponent<enemyShotPattern>().arrow = new Vector2(0, -DifficultyScene.difspd * 0.3f);
            cnt = 0;
        }

        //GetComponent<Rigidbody>().position += new Vector3(-0.1f * MirrorDirection, 0, 0);

        if (transform.position.x < -40) Destroy(gameObject);
        if (transform.position.x > 40) Destroy(gameObject);

        if (hp <= 0)
        {

            while (w < 50)
            {
                //Debug.Log(a);
                //Debug.Log(w);

                if (a % 2 == 0)
                {
                    Instantiate(Resources.Load("Item"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                else
                {
                    Instantiate(Resources.Load("PointItem"), transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity);
                }
                a = Random.Range(0, 99);
                w = Random.Range(0, 99);
            }

            imageTest.kari += 100;
            imageTest.scorejudge = 1;
            Destroy(gameObject);
        }

        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }

        if (d < 2.5f)
        {
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
        }
    }
    void enemymove11()
    {

    }
    void enemymove12()
    {

    }
    void enemymove13()
    {

    }
    void enemymove14()
    {

    }
    void enemymove15()
    {

    }
}
