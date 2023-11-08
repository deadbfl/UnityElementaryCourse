using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieDropManager : MonoBehaviour
{
    public static EnemyDieDropManager instance;

    [SerializeField] private GameObject[] dropObjects;

    private void Awake()
    {
        instance = this;
    }

    public void SpawnDropObject(Vector3 targetPos)
    {
        int index = Random.Range(0, dropObjects.Length);

        Instantiate(dropObjects[index], targetPos, Quaternion.identity);
    }
}
