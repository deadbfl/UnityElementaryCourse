using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float attackDelay;

    private EnemyAI enemyAI;

    private float attackTimer;

    private void Awake()
    {
        enemyAI = GetComponent<EnemyAI>();
        attackTimer = attackDelay;
    }

    private void Update()
    {
        if(enemyAI.currentEnemyState == EnemyState.Attack)
        {
            attackTimer -= Time.deltaTime;

            if(attackTimer < 0)
            {
                PlayerHealth.instance.DecreaseHealth(20);
                attackTimer = attackDelay;
            }
        }
    }
}
