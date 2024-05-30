using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMover : MonoBehaviour
{
    public float speed = 50f; // Speed at which the cloud moves
    public Vector2 startPosition = new Vector2(-100, 0); // Starting position of the cloud
    public Vector2 endPosition = new Vector2(100, 0); // Ending position of the cloud
    public bool moveLeftToRight = true; // Direction of movement

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = startPosition; // Set the initial position to startPosition
    }

    void Update()
    {
        // Determine the direction of movement
        Vector2 movement = (moveLeftToRight ? Vector2.right : Vector2.left) * speed * Time.deltaTime;

        // Move the cloud in the specified direction
        rectTransform.anchoredPosition += movement;

        // Check if the cloud has moved past the end position
        if (moveLeftToRight)
        {
            if (rectTransform.anchoredPosition.x >= endPosition.x)
            {
                // Move the cloud to the start position
                rectTransform.anchoredPosition = new Vector2(startPosition.x, rectTransform.anchoredPosition.y);
            }
        }
        else
        {
            if (rectTransform.anchoredPosition.x <= endPosition.x)
            {
                // Move the cloud to the start position
                rectTransform.anchoredPosition = new Vector2(startPosition.x, rectTransform.anchoredPosition.y);
            }
        }
    }
}
