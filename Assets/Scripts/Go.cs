using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour
{
    // Speed at which the player moves
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player in the +Z direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
