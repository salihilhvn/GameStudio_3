using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
    }
    
}