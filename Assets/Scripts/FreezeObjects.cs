using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class FreezeObjects : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject player;
    public float freezeDuration = 13.4f;

    private Rigidbody2D[] rigidbodies2D;
    private Rigidbody[] rigidbodies3D;
    private bool isFrozen = false;

    void Start()
    {
        // Find all rigidbodies in the scene
        rigidbodies2D = FindObjectsOfType<Rigidbody2D>();
        rigidbodies3D = FindObjectsOfType<Rigidbody>();

        // Start the freeze coroutine
        StartCoroutine(FreezeScene());
    }

    IEnumerator FreezeScene()
    {
        // Freeze all rigidbodies
        FreezeAll();

        // Wait for the specified duration
        yield return new WaitForSeconds(freezeDuration);

        // Unfreeze all rigidbodies
        UnfreezeAll();
    }

    void FreezeAll()
    {
        // Freeze 2D rigidbodies
        foreach (var rb in rigidbodies2D)
        {
            rb.simulated = false;
        }

        // Freeze 3D rigidbodies
        foreach (var rb in rigidbodies3D)
        {
            rb.isKinematic = true;
        }

        // Optionally disable player control scripts here
        // For example: player.GetComponent<PlayerController>().enabled = false;

        isFrozen = true;
    }

    void UnfreezeAll()
    {
        // Unfreeze 2D rigidbodies
        foreach (var rb in rigidbodies2D)
        {
            rb.simulated = true;
        }

        // Unfreeze 3D rigidbodies
        foreach (var rb in rigidbodies3D)
        {
            rb.isKinematic = false;
        }

        // Optionally re-enable player control scripts here
        // For example: player.GetComponent<PlayerController>().enabled = true;

        isFrozen = false;
    }

    void Update()
    {
        if (isFrozen)
        {
            // Optionally, add code to handle camera updates during the freeze if needed
        }
    }
}
