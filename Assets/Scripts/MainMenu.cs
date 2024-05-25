using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Replace "YourSceneName" with the name of your game scene
        SceneManager.LoadScene("Hippodrome");
        Debug.Log("Level 1 Loading");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void OpenOptions()
    {
        // Implement your options menu logic here
        Debug.Log("Options");
    }
}
