using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetTrigger(string key)
    {
        animator.SetTrigger(key);
    }

    public void DestroyGameObject(int score)
    {
        EnemyDieDropManager.instance.SpawnDropObject(transform.position);
        ScoreManager.instance.ChangeScore(score);
        Destroy(this.gameObject);
    }
}
