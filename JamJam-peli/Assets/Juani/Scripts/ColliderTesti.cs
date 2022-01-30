using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTesti : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.CompareTag("Item"))
        {
            Debug.Log("Testiosuma!!!!!!!!!");

        }
        
        //Debug.Log("OSUMA REKISTERÖITY ILMAN TAGIA");


    }
}
