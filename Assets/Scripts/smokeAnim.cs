using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeAnim : MonoBehaviour
{
    public float growthSpeed = 0.5f; // Büyüme hýzý
    public float upwardSpeed = 0.1f; // Yukarý hareket hýzý
    public float destroyHeight = 3.0f;

    private Vector3 originalScale; // Baþlangýç ölçeði
    private float originalY; // Baþlangýç yüksekliði

    void Start()
    {
        // Baþlangýç ölçeði ve yüksekliðini saklayýn
        originalScale = transform.localScale;
        originalY = transform.position.y;
    }

    void Update()
    {
        // Ölçeði ve yüksekliði zamanla arttýrýn
        transform.localScale += originalScale * growthSpeed * Time.deltaTime;
        transform.position += Vector3.up * upwardSpeed * Time.deltaTime;

        // Eðer yükseklik çok fazla artarsa objeyi yok edin
        if (transform.position.y - originalY >= destroyHeight)
        {
            Destroy(gameObject);
        }
    }
}
