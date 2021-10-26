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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (float.IsNaN(arrow.x)) arrow.x = 0;
        if (float.IsNaN(arrow.y)) arrow.y = 0;
        rb.position += new Vector3(arrow.x, 0, arrow.y);

        /*if (equipment == missile)
        {
            rb.AddRelativeForce(Vector3.forward*100);
        }*/
        if ( transform.position.z <= -player_ctrl.zlimit - 10 )
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
            Destroy(gameObject);
            shot.PowData = Player.gameObject.GetComponent<shot>().Power;
            Destroy(Player);
            Debug.Log("ピチューン！");
            ishit = true;
        }
    }
}
