using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    public Rigidbody player;
    private ParticleSystem effect;

    //Start is called before the first frame update
    void Start()
    {
        effect = GetComponent<ParticleSystem>();
        effect.Stop();
    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if(this.name == "Key (0)")
            {
                double_door_open.got_key_1 = true;
            }
            if (this.name == "Key (1)")
            {
                double_door_open.got_key_2 = true;
            }
            effect.Play();
            yield return new WaitForSeconds(.5f);
            Destroy(gameObject);
        }
    }
}