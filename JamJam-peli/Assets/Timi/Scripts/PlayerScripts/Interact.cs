using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private GameManager gameManagerScript;
    private Heite heiteScript;

    private void Start()
    {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
        heiteScript = GameObject.Find("läppäri_GJ22").GetComponent<Heite>();

    }


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
                    //hit.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                    hit.collider.gameObject.SetActive(false);
                    heiteScript.Osuma();
                }

            }
        }
    }

}
