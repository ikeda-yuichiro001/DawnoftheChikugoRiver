using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItem : MonoBehaviour
{
    public bool get;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Player == null)
        Player = GameObject.Find("player");

        GetComponent<Rigidbody>().position += new Vector3(0, 0, -0.3f);
        if (-player_ctrl.zlimit - 5 > transform.position.z) Destroy(gameObject);
        if (player_ctrl.xlimit < transform.position.x) transform.position = new Vector3(player_ctrl.xlimit,transform.position.y,transform.position.z);
        if (-player_ctrl.xlimit > transform.position.x) transform.position = new Vector3(-player_ctrl.xlimit, transform.position.y, transform.position.z);
        //アイテム上部回収
        if (Player != null)
        {
            if (Player.transform.position.z > player_ctrl.zlimit - 10)
            {
                transform.position = Player.transform.position;
            }
        }
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<shot>() != null)
        {
            imageTest.kari += 10000 * ((int)gameObject.transform.position.z + 45);
            imageTest.scorejudge = 1;
            Destroy(gameObject);
        }
    }
}