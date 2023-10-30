using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Bu Script Pistol Icin
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && PlayerWeaponManager.instance.bulletOfWeapons[0] > 0)
        {
            Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            
            PlayerWeaponManager.instance.DecreaseBulletCount();
        }
    }
}
