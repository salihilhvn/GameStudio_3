using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test2 : MonoBehaviour
{
    public float radius = 5.0f; // Radius of the circular path
    public float angularSpeed = 1.0f; // Angular speed of the movement
    public float jumpForce = 10.0f;   // The force applied when jumping

    private float angle = 0.0f; // Current angle
    private Rigidbody rb;
    private bool isJumping = false;
    public bool isGamePaused = false; // Flag to track if the game is paused

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Calculate the starting angle based on the position in the scene
        angle = Mathf.Atan2(transform.position.z, transform.position.x);
    }

    void Update()
    {
        // Check if the game is paused
        if (isGamePaused)
            return; // If paused, do not execute further code

        // Handle jumping
        if (Input.GetKeyDown(KeyCode.W) && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }

        // Update the angle based on angular speed
        angle += angularSpeed * Time.deltaTime;

        // Calculate the target position on the circular path
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;
        Vector3 targetPosition = new Vector3(x, transform.position.y, z);

        // Move the player to the target position
        transform.position = targetPosition;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if we hit the ground to reset jumping state
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        // Check if we collided with an enemy
        if (collision.gameObject.CompareTag("Shit"))
        {
            Debug.Log("You lose!"); // Print a debug message
            PauseGame(); // Pause the game
        }
    }

    // Function to pause the game
    void PauseGame()
    {
        Time.timeScale = 0f; // Set the time scale to zero to freeze the game
        isGamePaused = true; // Set the game pause flag
    }
}
