using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inst_fan : MonoBehaviour
{
    GameObject Player;
    GameObject Obj;
    public bool once = false;
    public int fannnelint = 0;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        /*switch (fannnelint)
        {
            default:

                break;
            case 1:
                if (!once)
                {
                    transform.position = new Vector3(0,0,1);
                    once = true;
                }
                break;
            case 2:
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
                break;
            case 3:
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
                break;
            case 4:
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
                break;
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Item>() != null)
        {
            //fannnelint++;
            Obj = (GameObject)Instantiate(Resources.Load("fannel"), transform.position, Quaternion.identity);
            Obj.transform.parent = Player.transform;
        }
    }
}
