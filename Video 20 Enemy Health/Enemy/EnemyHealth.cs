using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void ChangeCurrentHealth(int value)
    {
        currentHealth += value;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if(currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseHealth(int value)
    {
        ChangeCurrentHealth(value);
    }

    public void DecreaseHealth(int value)
    {
        ChangeCurrentHealth(-value);
    }
}
