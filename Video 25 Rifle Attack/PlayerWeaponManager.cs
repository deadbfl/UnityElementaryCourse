using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    [SerializeField] private GameObject[] weapons;

    [SerializeField] private WeaponType currentWeaponType;

    private PlayerAttack pistolAttack;
    private PlayerRifleAttack rifleAttack;

    private void Awake()
    {
        pistolAttack = GetComponent <PlayerAttack>();
        rifleAttack = GetComponent <PlayerRifleAttack>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeCurrentWeaponType(WeaponType.Weapon1);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeCurrentWeaponType(WeaponType.Weapon2);
    }

    private void ChangeCurrentWeaponType(WeaponType targetType)
    {
        if (targetType != currentWeaponType)
        {
            weapons[(int)currentWeaponType].SetActive(false);

            currentWeaponType = targetType;

            weapons[(int)currentWeaponType].SetActive(true);

            if(currentWeaponType == WeaponType.Weapon1)
            {
                pistolAttack.enabled = true;
                rifleAttack.enabled = false;
            }
            else if (currentWeaponType == WeaponType.Weapon2)
            {
                pistolAttack.enabled = false;
                rifleAttack.enabled = true;
            }
        }
    }
}

public enum WeaponType
{
    Weapon1,
    Weapon2,
}