using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeSpawner : MonoBehaviour
{
    public GameObject smokePrefab; // Oluþturulacak duman prefabý
    public Transform spawnPoint; // Spawn noktasý

    public float spawnInterval = 2.0f; // Oluþturma aralýðý

    public float timer = 0.0f;

    void Update()
    {
        // Timer'ý güncelle ve spawn aralýðýný kontrol et
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            // Timer sýfýrla
            timer = 0.0f;

            // Duman prefabýný belirtilen spawn noktasýndan oluþtur
            Instantiate(smokePrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
