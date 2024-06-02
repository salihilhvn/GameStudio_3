using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class portalCodes : MonoBehaviour
{
    public GameObject targetObject; // Aktif hale getirilecek obje
    public GameObject anotherObject;
    public float deactivateDelay = 5.0f;
    public Transform characterTransform; // Takip edilecek karakterin Transform komponenti
    public float yOffset = 0.0f; // Y ekseni için sabit ofset
    public float zOffset = 0.0f; // Z ekseni için sabit ofset
    private Vector3 initialPosition;




    void Start()
    {
       Invoke("DeactivateObject", deactivateDelay);
        initialPosition = transform.position;

      
    }
   

    void Update()
    {
        // Karakterin x eksenindeki pozisyonunu takip et
        transform.position = new Vector3(characterTransform.position.x, initialPosition.y + yOffset, initialPosition.z + zOffset);
    }

    void OnTriggerEnter(Collider other)
    {
       
        SetActived();
      

    }

    void DeactivateObject()
    {
        anotherObject.SetActive(false);
    }

    void SetActived()
    {

        if (targetObject != null)
        {
            targetObject.SetActive(true);
        }

    }

}
