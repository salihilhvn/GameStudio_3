using UnityEngine;

public class ArrowTrap : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] arrows;
    private float cooldownTimer;

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (cooldownTimer >= attackCooldown)
        {
            Attack();
        }
    }

    private void Attack()
    {
        cooldownTimer = 0;

        int arrowIndex = FindArrow();
        if (arrowIndex != -1)
        {
            GameObject arrow = arrows[arrowIndex];
            arrow.transform.position = firePoint.position;
            arrow.transform.rotation = firePoint.rotation;

            EnemyProjectile projectile = arrow.GetComponent<EnemyProjectile>();
            if (projectile != null)
            {
                projectile.ActivateProjectile();
            }
            else
            {
                Debug.LogWarning("Arrow does not have an EnemyProjectile component.");
            }
        }
    }

    private int FindArrow()
    {
        for (int i = 0; i < arrows.Length; i++)
        {
            if (!arrows[i].activeInHierarchy)
            {
                return i;
            }
        }
        // Eğer bütün oklar aktifse, -1 döner
        return -1;
    }
}