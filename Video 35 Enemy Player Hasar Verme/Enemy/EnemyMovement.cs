using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private Transform player;

    private EnemyAI enemyAI;

    private void Awake()
    {
        enemyAI = GetComponent<EnemyAI>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if(enemyAI.currentEnemyState == EnemyState.Walk)
        {
            transform.LookAt(player.position);
            transform.position = Vector3.MoveTowards(transform.position, player.position, movementSpeed * Time.deltaTime);
        }
    }
}
