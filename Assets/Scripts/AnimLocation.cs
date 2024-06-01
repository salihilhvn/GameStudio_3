using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimLocation : MonoBehaviour
{
    private Vector3 originalPosition;
    public float upwardSpeed = 1.0f;  // Yukarý hareket hýzý
    public float maxY = 5.0f; // Maksimum y eksen deðeri
    private float returnSpeed = 2.0f; // Geri dönüþ hýzý

    void Start()
    {
        // Objeyi baþlangýç pozisyonunda saklayýn
        originalPosition = transform.position;
    }

    void LateUpdate()
    {
        // Yukarý yönde hareket etmesini saðlayýn
        transform.Translate(Vector3.up * upwardSpeed * Time.deltaTime);

        // Eðer y ekseninde maksimum deðere ulaþýldýysa baþlangýç noktasýna geri dön
        if (transform.position.y >= maxY)
        {
            // Baþlangýç noktasýna geri dönme iþlemi
            float step = returnSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, step);
        }
    }
}
