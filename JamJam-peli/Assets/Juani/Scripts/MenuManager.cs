using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject infoPanel;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Peli alako");
        infoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Info()
    {
        infoPanel.SetActive(true);
    }

    public void Menu()
    {
        infoPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game pressed");
    }

}
