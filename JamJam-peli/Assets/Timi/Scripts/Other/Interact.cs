using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            float TheDistace = 1f; 
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.green);
            if (Physics.Raycast(transform.position, (forward), out hit))
            {
                hit.distance > TheDistace;

                {
                    if (hit.collider.tag == "Food")
                    {
                        hit.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                    }
                }
                //print(TheDistace + " " + hit.collider.gameObject.name);
            }
        }
    }
}
