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

        //Debug.Log("KST " + kST);

    }

    // Update is called once per frame
    void Update()
    {

        if (kST == 0)
        {
            if (aaniBool == true)
            {

                audioSourceList[0].clip = molyList[0];
                Debug.Log("0 aani");

                if (!audioSourceList[0].isPlaying)
                    audioSourceList[0].Play();

            }
            else
            {
                audioSourceList[0].Stop();
            }

        }

        if (kST == 1)
        {
            if (aaniBool == true)
            {

                audioSourceList[1].clip = molyList[1];
                Debug.Log("1 aani");

                if (!audioSourceList[1].isPlaying)
                    audioSourceList[1].Play();

            }
            else
            {
                audioSourceList[1].Stop();
            }
        }

        

        

        
        if (kST == 2)
        {
            if (aaniBool == true)
            {

                audioSourceList[2].clip = molyList[2];
                Debug.Log("2 aani");

                if (!audioSourceList[2].isPlaying)
                    audioSourceList[2].Play();

            }
            else
            {
                audioSourceList[2].Stop();
            }

        }
        if (kST == 3)
        {
            if (aaniBool == true)
            {

                audioSourceList[3].clip = molyList[3];
                Debug.Log("3 aani");

                if (!audioSourceList[3].isPlaying)
                    audioSourceList[3].Play();

            }
            else
            {
                audioSourceList[3].Stop();
            }
        }
        if (kST == 4)
        {
            if (aaniBool == true)
            {

                audioSourceList[1].clip = molyList[4];
                Debug.Log("4 aani");

                if (!audioSourceList[4].isPlaying)
                    audioSourceList[4].Play();

            }
            else
            {
                audioSourceList[4].Stop();
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
