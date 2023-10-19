using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private List<Transform> enemySpawnPoints;
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private float spawnTimer;

    private void Awake()
    {
        StartCoroutine(EnemySpawnCoroutine());
    }

    private IEnumerator EnemySpawnCoroutine()
    {
        while (true)
        {
            int index = Random.Range(0, enemySpawnPoints.Count);
            Transform spawnPoint = enemySpawnPoints[index];

            Instantiate(enemyPrefab,spawnPoint.position,Quaternion.identity);

            yield return new WaitForSeconds(spawnTimer);
        }
    }
}
