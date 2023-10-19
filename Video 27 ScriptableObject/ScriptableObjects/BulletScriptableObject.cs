using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects",fileName = "New Bullet Object")]
public class BulletScriptableObject : ScriptableObject
{
    public float speed;
    public int damage;
}
