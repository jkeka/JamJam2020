using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject source;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;


            if (Physics.Raycast(ray,out hit, 2))
            {
                if (hit.collider.tag == "Food")
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                }

                if (hit.collider.tag == "Kaappi")
                {
                    hit.collider.gameObject.GetComponent<Animation>().Play();
                }
            }
        }
    }

}
