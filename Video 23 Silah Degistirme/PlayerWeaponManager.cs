using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    [SerializeField] private GameObject weapon1;
    [SerializeField] private GameObject weapon2;

    [SerializeField] private WeaponType currentWeaponType;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeCurrentWeaponType(WeaponType.Weapon1);

        if(Input.GetKeyDown(KeyCode.Alpha2))
            ChangeCurrentWeaponType(WeaponType.Weapon2);
    }

    private void ChangeCurrentWeaponType(WeaponType targetType)
    {
        if(targetType != currentWeaponType)
        {
            currentWeaponType = targetType;
        }
    }
}

public enum WeaponType
{
    Weapon1,
    Weapon2,
}