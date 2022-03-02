using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urokoHansha : MonoBehaviour
{
    Vector3 Vector3;
    float d = 1;
    public bool ishit;
    GameObject Player;
    public Rigidbody rb;
    public Vector2 arrow;
    public static float HitRange = 1.0f;
    public bool isReflect;

    private Vector3 latestPos;  //前回のPosition

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector3 diff = transform.position - latestPos;   //前回からどこに進んだかをベクトルで取得
        latestPos = transform.position;  //前回のPositionの更新

        //ベクトルの大きさが0.01以上の時に向きを変える処理をする
        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff.normalized); //向きを変更する
        }
        

        if (float.IsNaN(arrow.x)) arrow.x = 0;
        if (float.IsNaN(arrow.y)) arrow.y = 0;
        rb.position += new Vector3(arrow.x, 0, arrow.y) * Time.deltaTime;


        if ( transform.position.z >= player_ctrl.zlimit + 20 || transform.position.z <= -player_ctrl.zlimit - 20 || transform.position.x >= player_ctrl.xlimit + 20 || transform.position.x <= -player_ctrl.xlimit - 20)
        {
            Destroy(gameObject);
        }
        if( transform.position.z >= player_ctrl.zlimit && !isReflect)
        {
            Vector3 = new Vector3(transform.position.x, transform.position.y, player_ctrl.zlimit - 10);
            arrow.y *= -1;
            isReflect = true;
        }
        if ((transform.position.x <= -player_ctrl.xlimit || transform.position.x >= player_ctrl.xlimit) && !isReflect)
        {
            arrow.x *= -1;
            isReflect = true;
        }

        if (Player != null)
        {
            d = Vector3.Distance(transform.position, Player.transform.position);
        }
        else
        {
            Destroy(gameObject);
        }

        if (d < HitRange && !ishit)
        {
            Instantiate(Resources.Load("player_ghost"), transform.position, Quaternion.identity);
            shot.PowData = Player.GetComponent<shot>().Power;
            Destroy(Player);
            Destroy(gameObject);
            ishit = true;
        }
    }
}
