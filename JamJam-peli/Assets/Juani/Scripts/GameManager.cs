using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Globaali int joka pit‰‰ lukua pelikierroksista
    //public static int peliKierrokset = 0;
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
        //peliKierrokset = peliKierrokset + 1;

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
                Debug.Log("YLakertaBile aani");

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
                Debug.Log("Lapset ulkona aani");

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

                audioSourceList[6].clip = molyList[2];
                Debug.Log("Remontti alakerta aani");

                if (!audioSourceList[6].isPlaying)
                    audioSourceList[6].Play();

            }
            else
            {
                audioSourceList[6].Stop();
            }

        }
        if (kST == 3)
        {
            if (aaniBool == true)
            {

                audioSourceList[3].clip = molyList[3];
                Debug.Log("Seksia");

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

                audioSourceList[4].clip = molyList[4];
                Debug.Log("Juusto aani");

                if (!audioSourceList[4].isPlaying)
                    audioSourceList[4].Play();

            }
            else
            {
                audioSourceList[4].Stop();
            }
        }
        if (kST == 5)
        {
            if (aaniBool == true)
            {

                audioSourceList[5].clip = molyList[5];
                Debug.Log("Pierua");

                if (!audioSourceList[5].isPlaying)
                    audioSourceList[5].Play();

            }
            else
            {
                audioSourceList[5].Stop();
            }
        }
        if (kST == 6)
        {
            if (aaniBool == true)
            {

                audioSourceList[6].clip = molyList[6];
                Debug.Log("6 aani");

                if (!audioSourceList[6].isPlaying)
                    audioSourceList[6].Play();

            }
            else
            {
                audioSourceList[6].Stop();
            }
        }
        if (kST == 7)
        {
            if (aaniBool == true)
            {

                audioSourceList[5].clip = molyList[6];
                Debug.Log("Pieru aani");

                if (!audioSourceList[5].isPlaying)
                    audioSourceList[5].Play();

            }
            else
            {
                audioSourceList[5].Stop();
            }
        }

        if (kST == 8)
        {
            SceneManager.LoadScene("AnimationScene");

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
