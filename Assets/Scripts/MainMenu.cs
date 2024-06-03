using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject mainMenuPanel;
    public GameObject optionsMenuPanel;

    private void Start()
    {
        mainMenuPanel.SetActive(true);
        optionsMenuPanel.SetActive(false);
    }

    public void PlayGame()
    {
        // Replace "YourSceneName" with the name of your game scene
        SceneManager.LoadScene(2);
        Debug.Log("Level 1 Loading");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        
    }

    public void OpenOptions()
    {
        mainMenuPanel.SetActive(false);
        optionsMenuPanel.SetActive(true);
        Debug.Log("Options");
    }

    public void CloseOptions()
    {
        mainMenuPanel.SetActive(true);
        optionsMenuPanel.SetActive(false);
    }
}
