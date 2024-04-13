using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval = 1f;
    public Transform spawnPointA;
    public Transform spawnPointB;

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
