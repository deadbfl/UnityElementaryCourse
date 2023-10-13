using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;

    private void Awake()
    {
        Destroy(this.gameObject, lifetime);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed *Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealth>().DecreaseHealth(20);
            Destroy(this.gameObject);
        }
    }
}
