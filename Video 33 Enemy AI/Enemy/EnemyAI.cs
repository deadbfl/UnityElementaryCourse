using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public bool isInsideOfPlayer;

    [SerializeField] private EnemyState currentEnemyState;

    private void Awake()
    {
        ChangeEnemyState(EnemyState.Walk);
    }

    public void ChangeEnemyState(EnemyState state)
    {
        if(currentEnemyState != state)
        {
            currentEnemyState = state;
        }
    }
}

public enum EnemyState
{
    Idle,
    Walk,
    Attack,
    Die,
}