using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimaatioSceneManageri : MonoBehaviour
{

    private IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {

        coroutine = WaitTillAnimationOver();
        StartCoroutine(coroutine);


    }

    IEnumerator WaitTillAnimationOver()
    {
        yield return new WaitForSeconds(22.0f);
        Debug.Log("Aloita peli skene");
        SceneManager.LoadScene("MainScene");


    }
}
