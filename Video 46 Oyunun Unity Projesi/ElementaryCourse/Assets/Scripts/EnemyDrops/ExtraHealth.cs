using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraHealth : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        PlayerHealth.instance.IncreaseHealth(20);
    }
}
