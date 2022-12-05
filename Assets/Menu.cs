using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject aboutPanel;
    public GameObject exitPanel;

    // Use this for initialization
    void Start()
    {
        mainMenuPanel.SetActive(true);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);

    }

    public void StartGameClick()
    {
        SceneManager.LoadScene("Game");

    }
    public void YesInGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AboutClicked()
    {
        aboutPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void ExitClicked()
    {
        exitPanel.SetActive(true);
        aboutPanel.SetActive(false);
        mainMenuPanel.SetActive(false);
    }

    public void NoClicked()
    {
        mainMenuPanel.SetActive(true);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void YesGameClick()
    {
        Application.Quit();
        Debug.Log("Keluar dari aplikasi");
    }

    


    public void BackClicked()
    {
        mainMenuPanel.SetActive(true);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);

    }
}
