using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class double_door_open : MonoBehaviour
{
    private BoxCollider trigger;
    private Animator open;

    // Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<BoxCollider>();
        open = GetComponent<Animator>();
        open.Play("door_1_closed", 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            open.Play("door_1_open",0, 0);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Player")
        {
            open.Play("door_1_opened", 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
