using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<ICollectable>() !=  null)
        {
            other.GetComponent<ICollectable>().Collect();
            Destroy(other.gameObject);
        }
    }
}
