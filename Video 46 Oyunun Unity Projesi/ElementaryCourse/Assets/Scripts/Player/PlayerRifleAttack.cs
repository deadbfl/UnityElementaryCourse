using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRifleAttack : MonoBehaviour
{
    // Bu Script Rifle Icin

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;

    [SerializeField] private float targetTime = 0.2f;
    private float bulletSpawnTimer = 1;

    private bool isShooting;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            isShooting = true;

        if (Input.GetMouseButtonUp(0))
            isShooting = false;

        bulletSpawnTimer -= Time.deltaTime;

        if (PlayerWeaponManager.instance.bulletOfWeapons[1] > 0 && isShooting && bulletSpawnTimer < 0)
        {
            Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            PlayerWeaponManager.instance.DecreaseBulletCount();

            bulletSpawnTimer = targetTime;
        }
    }
}

