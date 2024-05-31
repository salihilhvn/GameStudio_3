using UnityEngine;

public class ArrowTrap : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject arrowPrefab;
    private bool arrowFired = false;
    private float timeSinceStart = 0f;

    private void Update()
    {
        timeSinceStart += Time.deltaTime;

        if (!arrowFired && timeSinceStart >= attackCooldown)
        {
            FireArrow();
        }
    }

    private void FireArrow()
    {
        arrowFired = true;

        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
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