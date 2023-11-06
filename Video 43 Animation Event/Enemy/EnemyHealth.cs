using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthBase
{
    private bool isDeath = false;
    public override void Die()
    {
       if(!isDeath)
        {
            GetComponent<EnemyAI>().MakeDesicion();
            isDeath = true;
        }
    }
}
