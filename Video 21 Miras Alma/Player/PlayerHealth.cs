using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthBase
{
    public override void Die()
    {
        base.Die();
        Debug.Log("Player Die");
    }
}
