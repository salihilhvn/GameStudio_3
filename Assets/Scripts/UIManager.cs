using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Panel referansı

    private bool isPaused = false;
    public GameObject settingsPanel;

    void Update()
    {
        // ESC tuşuna basıldığında duraklatma menüsünü aç/kapat
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    // Oyunu duraklatır
    public void PauseGame()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f; 
        isPaused = true;
    }

    // Oyunu devam ettirir
    public void ResumeGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f; 
        isPaused = false;
    }

    // Başlangıç sahnesini yükler
    public void LoadStartScene()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("StartScene"); 
    }

    // Oyun sahnesini yükler
    public void LoadGameScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene"); 
    }

    // Ayarlar sahnesini yükler
    public void LoadSettingsScene()
    {
        //Time.timeScale = 1f; // Zamanı normal hızına döndür
        //SceneManager.LoadScene("SettingsScene"); 
        settingsPanel.SetActive(true);
        
    }

 
    public void RetryGame()
    {
        Time.timeScale = 1f; 
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    // Ana menü sahnesini yükler
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(0); 
    }

    // Oyunu kapatır
    public void QuitGame()
    {
        Application.Quit();
    }
}
