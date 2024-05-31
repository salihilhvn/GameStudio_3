using System.Collections;
using UnityEngine;

public class FallingObjectSpawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab; // Düşecek objenin prefab'ı
    public float spawnInterval = 3.0f; // Objelerin düşme aralığı
    public float spawnRangeX = 10.0f; // Objelerin yatayda spawn olacağı aralık
    public float zOffset = 5.0f; // Her yeni objenin Z ekseninde ne kadar ileride spawn olacağı
    private float currentZ; // Son oluşturulan objenin Z koordinatı

    private void Start()
    {
        currentZ = 0f; // Başlangıç Z koordinatı
        StartCoroutine(SpawnFallingObjects());
    }

    private IEnumerator SpawnFallingObjects()
    {
        while (true)
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnObject()
    {
        // Objenin spawn olacağı yeri belirleyin
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX), 
            10f, 
            currentZ);
        
        // Yeni objeyi oluştur
        Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);

        // Bir sonraki obje için Z koordinatını güncelle
        currentZ += zOffset;
    }
}