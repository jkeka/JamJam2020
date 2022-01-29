using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{

    public ParticleSystem effect;

    void Start()
    {
        effect.Stop();
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.CompareTag("Item"))
        {
            effect.Play();
        }

    }

}
