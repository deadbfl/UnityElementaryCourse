using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthBase
{
    public override void Die()
    {
        base.Die();
        Debug.Log("Enemy Die");
    }
}
