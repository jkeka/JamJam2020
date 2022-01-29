using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osuma : MonoBehaviour
{

    public ParticleSystem waterEffect;
    private IEnumerator coroutine;

    private GameManager gameManagerScript;


        void Start()
    {

        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();


        waterEffect.Stop();

        coroutine = WaitBeforeNextTask();

    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.CompareTag("Putki"))
        {
            Debug.Log("Vesi p‰‰lle");
            waterEffect.Play();
        }

        StartCoroutine(coroutine);
        gameManagerScript.audioSourceList[0].Stop();

    }


    IEnumerator WaitBeforeNextTask()
    {
        Debug.Log("WaitBeforeNextTask alkoi");
        gameManagerScript.aaniBool = true;
        yield return new WaitForSeconds(3.0f);
        Debug.Log("3 s kulunut, lis‰‰ yksi KST:hen");
        waterEffect.Stop();

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

        Debug.Log("KST " + gameManagerScript.kST);



    }

}