using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{
    public float laneDistance = 2.0f; // The distance between the lanes
    public float jumpForce = 10.0f;   // The force applied when jumping
    public float moveSpeed = 5.0f;    // The speed of forward movement

    private int currentLane = 1;      // Start in the middle lane (0: left, 1: middle, 2: right)
    private Rigidbody rb;
    private bool isJumping = false;
    public bool isGamePaused = false; // Flag to track if the game is paused

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the game is paused
        if (isGamePaused)
            return; // If paused, do not execute further code

        // Handle lane switching
        if (Input.GetKeyDown(KeyCode.A) && currentLane > 0)
        {
            currentLane--;
        }
        if (Input.GetKeyDown(KeyCode.D) && currentLane < 2)
        {
            currentLane++;
        }

        // Handle jumping
        if (Input.GetKeyDown(KeyCode.W) && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }

        // Move the player forward continuously
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, moveSpeed);

        // Smoothly transition between lanes
        Vector3 targetPosition = new Vector3(currentLane * laneDistance - laneDistance, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);
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
