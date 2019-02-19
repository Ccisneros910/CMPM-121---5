using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class double_door_open : MonoBehaviour
{
    private BoxCollider trigger;
    private Animator open;
    public static bool got_key_1, got_key_2;

    // Start is called before the first frame update
    void Start()
    {
        got_key_1 = false;
        got_key_2 = false;
        trigger = GetComponent<BoxCollider>();
        open = GetComponent<Animator>();
        //open.Play("door_1_closed", 0, 0);
    }

    private void OnTriggerStay(Collider other)
    {
        if (got_key_1 == true && got_key_2 == true)
        {
            open.Play("door_1_open", 0, 0);
            open.Play("door_1_opened", 0, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        open.Play("door_1_closed", 0, 0);
    }
}
