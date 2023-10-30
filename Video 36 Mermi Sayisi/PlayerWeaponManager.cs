using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    public static PlayerWeaponManager instance;

    [SerializeField] private GameObject[] weapons;

    public int[] bulletOfWeapons;

    [SerializeField] private WeaponType currentWeaponType;

    [SerializeField] private TMP_Text bulletText;

    private void Awake()
    {
        instance = this;

        UpdateBulletTextCount();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeCurrentWeaponType(WeaponType.Pistol);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeCurrentWeaponType(WeaponType.Rifle);
    }

    private void ChangeCurrentWeaponType(WeaponType targetType)
    {
        if (targetType != currentWeaponType)
        {
            weapons[(int)currentWeaponType].SetActive(false);

            currentWeaponType = targetType;

            weapons[(int)currentWeaponType].SetActive(true);

            UpdateBulletTextCount();
        }
    }

    public void DecreaseBulletCount()
    {
        bulletOfWeapons[(int)currentWeaponType]--;
        UpdateBulletTextCount();
    }

    private void UpdateBulletTextCount()
    {
        bulletText.SetText(bulletOfWeapons[(int)currentWeaponType].ToString());
    }
}

public enum WeaponType
{
    Pistol,
    Rifle,
}

public enum BulletType
{
   PistolBullet,
   RifleBullet,
}