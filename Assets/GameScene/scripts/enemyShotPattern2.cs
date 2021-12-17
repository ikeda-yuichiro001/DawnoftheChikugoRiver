using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShotPattern2 : MonoBehaviour
{
    float d = 1;
    public bool ishit;
    GameObject Player;
    public Rigidbody rb;
    public Vector2 arrow;
    public static float HitRange = 2f;

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
        if (transform.position.z > player_ctrl.zlimit + 10 || transform.position.z < -player_ctrl.zlimit - 10 || transform.position.x < -player_ctrl.xlimit - 10 || transform.position.x > player_ctrl.xlimit + 10)
        {
            Destroy(gameObject);
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
            if (Player != null)
                shot.PowData = Player.GetComponent<shot>().Power;
            Destroy(Player);
            Destroy(gameObject);
            ishit = true;
        }
    }
}
