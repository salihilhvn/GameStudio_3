using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Sahne yönetimi için gerekli


public class NextScenePortal : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SonrakiSahneyeGec();
     }

    void SonrakiSahneyeGec()
    {
        // Þuanki sahnenin indeksini al
        int suankiSahneIndex = SceneManager.GetActiveScene().buildIndex;

        // Bir sonraki sahnenin indeksini hesapla
        int sonrakiSahneIndex = suankiSahneIndex + 1;

        // Eðer bir sonraki sahne mevcutsa, o sahneye geç
        if (sonrakiSahneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sonrakiSahneIndex);
        }
    }
}
