using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMovement : MonoBehaviour
{
    public float floatSpeed = 1.0f; // Objenin yukarý aþaðý hareket hýzýný kontrol eder
    public float floatAmplitude = 0.5f; // Objenin yukarý aþaðý hareket geniþliðini kontrol eder
    public float rotationSpeed = 30.0f; // Objenin z ekseninde döndürme hýzýný kontrol eder

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position; // Objenin baþlangýç pozisyonunu kaydet
    }

    void Update()
    {
        // Yukarý ve aþaðý hareket
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Z ekseninde döndürme
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
