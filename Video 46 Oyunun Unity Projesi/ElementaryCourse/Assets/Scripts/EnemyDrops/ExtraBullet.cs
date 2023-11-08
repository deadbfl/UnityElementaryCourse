using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBullet : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        PlayerWeaponManager.instance.UpdateBulletCount();
    }
}
