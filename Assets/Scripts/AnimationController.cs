using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Left A");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Right D");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Jump W");
        }
    }
}
