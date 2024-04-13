using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private Transform spawnPointA;
    [SerializeField] private Transform spawnPointB;

    private float timer;

    void Start()
    {
        timer = spawnInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnPrefab();
            timer = spawnInterval;
        }
    }

    void SpawnPrefab()
    {
        if (prefabToSpawn != null && spawnPointA != null && spawnPointB != null)
        {
            Vector3 spawnPosition = Vector3.Lerp(spawnPointA.position, spawnPointB.position, Random.value);
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
