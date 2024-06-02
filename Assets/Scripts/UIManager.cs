using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Panel referansı
    public GameObject SettingsMenuPanel;
    private bool isPaused = false;

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
        Time.timeScale = 0f; // Oyunu duraklatır
        isPaused = true;
    }

    // Oyunu devam ettirir
    public void ResumeGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f; // Oyunu devam ettirir
        isPaused = false;
    }

    // Başlangıç sahnesini yükler
    public void LoadStartScene()
    {
        Time.timeScale = 1f; // Zamanı normal hızına döndür
        SceneManager.LoadScene("StartScene"); // StartScene ismini kendi sahne isminizle değiştirin
    }

    // Oyun sahnesini yükler
    public void LoadGameScene()
    {
        Time.timeScale = 1f; // Zamanı normal hızına döndür
        SceneManager.LoadScene("GameScene"); // GameScene ismini kendi sahne isminizle değiştirin
    }

    // Ayarlar sahnesini yükler
    public void LoadSettingsScene()
    {
        Time.timeScale = 1f; // Zamanı normal hızına döndür
        SettingsMenuPanel.SetActive(true);
    }

    // Oyunu yeniden başlatır (şu anki sahneyi yeniden yükler)
    public void RetryGame()
    {
        Time.timeScale = 1f; // Zamanı normal hızına döndür
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    // Ana menü sahnesini yükler
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Zamanı normal hızına döndür
        SceneManager.LoadScene(0); // MainMenu ismini kendi sahne isminizle değiştirin
    }

    // Oyunu kapatır
    public void QuitGame()
    {
        Application.Quit();
    }
}
