using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EndPortalAudio : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        // AudioSource bileþenini al
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        // Obje etkinleþtirildiðinde AudioSource'un çalmasýný saðla
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            UnityEngine.Debug.LogWarning("AudioSource bileþeni bulunamadý!");
        }
    }
}
