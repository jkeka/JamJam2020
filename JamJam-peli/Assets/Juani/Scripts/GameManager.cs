using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Globaali int joka pit‰‰ lukua pelikierroksista
    public static int peliKierrokset = 0;
    public int kST; //Kierroksen sis‰inen taso, m‰‰r‰‰ kulloinkin kuuluvan ‰‰nen ja teht‰v‰n

    //Mˆly‰‰net
    public List<AudioClip> molyList = new List<AudioClip>();

    //ƒ‰ni booleanit
    public bool aaniBool = false;

    //Audiosourcet
    public List<AudioSource> audioSourceList = new List<AudioSource>();


    // Start is called before the first frame update
    void Start()
    {
        peliKierrokset = peliKierrokset + 1;

        kST = 0;

        Debug.Log("KST " + kST);

    }

    // Update is called once per frame
    void Update()
    {
        if (kST == 0)
        {
            if (aaniBool == true)
            {

                audioSourceList[1].clip = molyList[1];
                audioSourceList[1].Play();

            }

        }
        if (kST == 1)
        {
            if (aaniBool == true)
            {

                audioSourceList[2].clip = molyList[2];
                audioSourceList[2].Play();
            }

        }
        if (kST == 2)
        {
            if (aaniBool == true)
            {

                audioSourceList[3].clip = molyList[3];
                audioSourceList[3].Play();
            }
        }
        if (kST == 3)
        {
            if (aaniBool == true)
            {

                audioSourceList[4].clip = molyList[4];
                audioSourceList[4].Play();
            }
        }


    }
    /*
    public void LisaaYksiKST()
    {
        kST++;
        Debug.Log(kST);
    }
    */
}
