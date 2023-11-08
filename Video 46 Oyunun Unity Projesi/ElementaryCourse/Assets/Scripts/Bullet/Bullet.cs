using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private BulletScriptableObject bulletType; 

    [SerializeField] private float lifetime;

    private void Awake()
    {
        Destroy(this.gameObject, lifetime);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * bulletType.speed *Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealth>().DecreaseHealth(bulletType.damage);
            Destroy(this.gameObject);
        }
    }
}
