using System.Collections;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab; // Prefab for the platform
    [SerializeField] private GameObject obstaclePrefab; // Prefab for the obstacle
    [SerializeField] private float platformSpawnInterval = 2f; // Time interval between spawns
    [SerializeField] private float platformDespawnInterval = 6f; // Time interval between despawns
    [SerializeField] private float obstacleSpawnInterval = 6f; // Time interval between spawns
    [SerializeField] private float obstacleDespawnInterval = 6f; // Time interval between despawns
    [SerializeField] private Transform spawnPoint; // Point where platforms will be spawned

    private void Start()
    {
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
    }

    //private void Update()
    //{
    //    // Check if the player has collided with an obstacle
    //    if (GameManager.instance.IsGameOver)
    //    {
    //        StopAllCoroutines(); // Stop all coroutines when the game is over
    //    }
    //}

    private IEnumerable SpawnObstacle()
    {
        yield return new WaitForSeconds(obstacleSpawnInterval);

        GameObject obstacle = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
        Destroy(obstacle, obstacleDespawnInterval); // Destroy the obstacle after 5 seconds when the obstacle is off screen
    }

    private IEnumerable SpawnPlatform()
    {
        yield return new WaitForSeconds(platformSpawnInterval);

        GameObject platform = Instantiate(platformPrefab, spawnPoint.position, Quaternion.identity);
        Destroy(platform, platformDespawnInterval); // Destroy the obstacle after 5 seconds when the obstacle is off screen
    }
}
