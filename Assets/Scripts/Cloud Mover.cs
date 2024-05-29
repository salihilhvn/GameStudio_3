using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloudMover : MonoBehaviour
{
    public float speed = 50f; // Speed at which the cloud moves
    private RectTransform rectTransform;
    private float screenWidth;
    private float initialYPosition;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        screenWidth = Screen.width;
        initialYPosition = rectTransform.anchoredPosition.y; // Store the initial vertical position
    }

    void Update()
    {
        // Move the cloud to the right
        rectTransform.anchoredPosition += Vector2.right * speed * Time.deltaTime;

        // Check if the cloud has moved past the right edge of the screen
        if (rectTransform.anchoredPosition.x - rectTransform.rect.width / 2 > screenWidth)
        {
            // Move the cloud to the left edge of the screen at the initial vertical position
            rectTransform.anchoredPosition = new Vector2(-rectTransform.rect.width / 2, initialYPosition);
        }
    }
}
