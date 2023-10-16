using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    public static PlayerAiming instance;

    public bool isAiming;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
            isAiming = true;
        if (Input.GetMouseButtonUp(1))
            isAiming = false;
    }
}
