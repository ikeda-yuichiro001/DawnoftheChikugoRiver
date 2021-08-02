using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool get;
    public static GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
    }

    void Update()
    {
        GetComponent<Rigidbody>().position += new Vector3(0,0,-0.3f);

        if (-player_ctrl.zlimit - 5 > transform.position.z) Destroy(gameObject);
        if (player_ctrl.xlimit < transform.position.x) transform.position = new Vector3(player_ctrl.xlimit, transform.position.y, transform.position.z);
        if (-player_ctrl.xlimit > transform.position.x) transform.position = new Vector3(-player_ctrl.xlimit, transform.position.y, transform.position.z);

        //アイテム上部回収

        Debug.Log(Player.transform.position.z);
        Debug.Log(player_ctrl.zlimit - 15);
        if (Player.transform.position.z > player_ctrl.zlimit - 15)
        {
            GetComponent<SphereCollider>().center = new Vector3(100, 100, 100);
        }
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<shot>() != null) {

            other.GetComponent<shot>().UpPower();
            Destroy(gameObject);
        }
    }
}
