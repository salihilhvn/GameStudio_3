using UnityEngine;

public class EnemyProjectile : EnemyDamage
{
    [SerializeField] private float speed;
    [SerializeField] private float resetTime;
    private float lifetime;
    private bool isStuck = false;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.isKinematic = true;
    }

    public void ActivateProjectile()
    {
        lifetime = 0;
        isStuck = false;
        rb.isKinematic = false; // Ok tekrar aktif olduğunda hareket edebilir
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if (!isStuck)
        {
            MoveProjectile();
        }
        CheckLifetime();
    }

    private void MoveProjectile()
    {
        float movementSpeed = speed * Time.deltaTime;
        transform.Translate(Vector3.forward * movementSpeed);
    }

    private void CheckLifetime()
    {
        lifetime += Time.deltaTime;
        if (lifetime > resetTime && !isStuck)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Ok saplandığı yerde kalsın ve hareket etmesin
        isStuck = true;
        rb.isKinematic = true; // Ok saplandığında hareket etmesin
        rb.velocity = Vector3.zero; // Hızını sıfırla
        rb.angularVelocity = Vector3.zero; // Dönme hızını sıfırla
    }
}