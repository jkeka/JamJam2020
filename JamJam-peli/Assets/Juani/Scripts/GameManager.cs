using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Globaali int joka pit‰‰ lukua pelikierroksista
    public static int peliKierrokset = 0;




    // Start is called before the first frame update
    void Start()
    {
        peliKierrokset = peliKierrokset + 1;
        Debug.Log(peliKierrokset);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
