using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCinematic : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject player;
    public Animator cameraAnimator;
    public string animationName = "CameraPan";
    public float animationDuration = 5f;

    private bool cinematicDone = false;

    void Start()
    {
        // Start the camera animation
        cameraAnimator.Play(animationName);
        StartCoroutine(EndCinematic());
    }

    IEnumerator EndCinematic()
    {
        // Wait for the animation to finish
        yield return new WaitForSeconds(animationDuration);

        // Reattach the camera to the player
        mainCamera.transform.SetParent(player.transform);
        mainCamera.transform.localPosition = new Vector3(0, 0, -10); // Adjust this according to your setup
        mainCamera.transform.localRotation = Quaternion.identity;

        cinematicDone = true;
    }

    void Update()
    {
        if (!cinematicDone)
        {
            // Optionally, add code to handle camera updates during the cinematic if needed
        }
    }
}
