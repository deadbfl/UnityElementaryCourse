using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float distanceFromPlayer;

    private void Update()
    {
        distanceFromPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceFromPlayer < detectPlayerDistance)
        {
            EnemySpawnManager.instance.SaveSpawnPoint(transform);
        }
        else
        {
            EnemySpawnManager.instance.RemoveSpawnPoint(transform);
        }
    }

}
