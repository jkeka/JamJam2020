using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osuma : MonoBehaviour
{

    public ParticleSystem waterEffect;
    private IEnumerator coroutine;
    private IEnumerator viive;


    private GameManager gameManagerScript;


        void Start()
    {

        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();



        coroutine = WaitBeforeNextTask();
        viive = ViiveMetodi();

    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.CompareTag("Putki"))
        {
            Debug.Log("Vesi p‰‰lle");
            waterEffect.Play();
            StartCoroutine(viive);
        }

        if (col.gameObject.CompareTag("Kid"))
        {
            Debug.Log("Lapsiosuma");

        }

        if (col.gameObject.CompareTag("Katto"))
        {
            Debug.Log("Katto-osuma");

        }
        
        StartCoroutine(coroutine);
        gameManagerScript.audioSourceList[0].Stop();
        
    }


        IEnumerator WaitBeforeNextTask()
    {
        Debug.Log("WaitBeforeNextTask alkoi");
        gameManagerScript.aaniBool = true;
        yield return new WaitForSeconds(3.0f);
        //Debug.Log("3 s kulunut, lis‰‰ yksi KST:hen");

        gameManagerScript.kST++;
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

        //Debug.Log("KST " + gameManagerScript.kST);



    }

    IEnumerator ViiveMetodi()
    {
        yield return new WaitForSeconds(2.0f);
        waterEffect.Stop();


    }

}