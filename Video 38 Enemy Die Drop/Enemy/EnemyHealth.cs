using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthBase
{
    public override void Die()
    {
        EnemyDieDropManager.instance.SpawnDropObject(transform.position);
        base.Die();
    }
}
