using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    // Speed of rotation in degrees per second
    public float rotationSpeed = 100f;

    // Axis of rotation
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        // Rotate the object around the specified axis at the specified speed
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
