using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{

    public GameObject deathPanel;
    public GameObject optionsMenuPanel;
    public GameObject pausedPanel;

    private void Start()
    {
        deathPanel.SetActive(false);
        optionsMenuPanel.SetActive(false);
        pausedPanel.SetActive(false);       
    }

    public void OpenDeathPanel()
    {
        deathPanel.SetActive(true);
    }

    public void CloseDeathPanel()
    {
        deathPanel.SetActive(false);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void OpenPause()
    {
        pausedPanel.SetActive(true);
    }

    public void ClosePause()
    {
        pausedPanel.SetActive(false);
    }
}
