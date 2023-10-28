using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public bool isInsideOfPlayer;

    [SerializeField] private EnemyState currentEnemyState;

    private EnemyHealth enemyHealth;

    private void Awake()
    {
        enemyHealth = GetComponent<EnemyHealth>();
    }

    private void Start()
    {
        ChangeEnemyState(EnemyState.Idle);
    }

    public void ChangeEnemyState(EnemyState state)
    {
        if(currentEnemyState != state)
        {
            currentEnemyState = state;

            if(currentEnemyState == EnemyState.Idle)
            {
                if(enemyHealth.currentHealth <= 0)
                {
                    currentEnemyState = EnemyState.Die;
                }
                else if(isInsideOfPlayer)
                {
                    currentEnemyState = EnemyState.Attack;
                }
                else
                {
                    currentEnemyState = EnemyState.Walk;
                }
            }
        }
    }
}

public enum EnemyState
{
    Null,
    Idle,
    Walk,
    Attack,
    Die,
}