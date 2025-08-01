using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EndPortalAudio : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        // AudioSource bileşenini al
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        // Obje etkinleştirildiğinde AudioSource'un çalmasını sağla
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            UnityEngine.Debug.LogWarning("AudioSource bileşeni bulunamadı!");
        }
    }
}
