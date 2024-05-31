using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceEmptyObject : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}
