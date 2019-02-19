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
            effect.Play();
            yield return new WaitForSeconds(.5f);
            Destroy(gameObject);
        }
    }
}