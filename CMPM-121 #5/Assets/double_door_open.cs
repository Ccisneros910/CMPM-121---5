using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class double_door_open : MonoBehaviour
{
    private BoxCollider trigger;
    private Animator anim;
    public static bool got_key_1;
    public static bool got_key_2;
    public static bool got_key_3;

    // Start is called before the first frame update
    void Start()
    {
        got_key_1 = false;
        got_key_2 = false;
        got_key_3 = false;
        trigger = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        //open.SetBool("door_1_closed", true);
        //open.Play("door_1_closed", 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.name == "door_2 (1)")
        {
            if (other.name == "Player" && got_key_1 == true && got_key_2 == true)
            {
                //open.SetBool("door_1_closed", false);
                anim.Play("door_2_open");
                //WaitForSeconds(1);
            }
        }
        if (this.name == "door_2" && got_key_3 == true)
        {
            if (other.name == "Player" && got_key_3 == true)
            {
                anim.Play("door_2_open");
            }

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (this.name == "door_2 (1)")
        {
            if (other.name == "Player" && got_key_1 == true && got_key_2 == true)
            {
                //open.SetBool("door_1_closed", false);
                anim.Play("door_2_close");
                //WaitForSeconds(1);
            }
        }
        if (this.name == "door_2" && got_key_3 == true)
        {
            if (other.name == "Player" && got_key_3 == true)
            {
                anim.Play("door_2_close");
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
