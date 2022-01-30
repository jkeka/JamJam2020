using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heite : MonoBehaviour
{

    public ParticleSystem waterEffect;
    //private IEnumerator coroutine;
    private IEnumerator viive;


    private GameManager gameManagerScript;


    void Start()
    {

        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();



        //coroutine = WaitBeforeNextTask();
        viive = ViiveMetodi();
        gameManagerScript.aaniBool = true;
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.CompareTag("Putki"))
        {
            Debug.Log("Vesi p‰‰lle");
            Osuma();
            waterEffect.Play();
            StartCoroutine(viive);


        }

        if (col.gameObject.CompareTag("Kid"))
        {
            Debug.Log("Lapsiosuma");
            Osuma();

        }

        if (col.gameObject.CompareTag("Katto"))
        {
            Debug.Log("Katto-osuma");
            Osuma();


        }



    }



    public void Osuma()
    {
        {
            Debug.Log("Osuma metodi");



            gameManagerScript.kST++;
            
            if (gameManagerScript.kST == 1)
            {
                gameManagerScript.audioSourceList[0].Stop();

            }
            if (gameManagerScript.kST == 2)
            {
                gameManagerScript.audioSourceList[1].Stop();

            }
            if (gameManagerScript.kST == 3)
            {
                gameManagerScript.audioSourceList[2].Stop();

            }
            if (gameManagerScript.kST == 4)
            {
                gameManagerScript.audioSourceList[3].Stop();

            }
            
            Debug.Log("KST " + gameManagerScript.kST);



        }
    }


    IEnumerator ViiveMetodi()
    {
        yield return new WaitForSeconds(2.0f);
        waterEffect.Stop();


    }

}