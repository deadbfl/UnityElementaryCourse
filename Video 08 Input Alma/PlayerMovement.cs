using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float horizontal; // x eksenindeki hareketi tutacak (x sag sol)
    [SerializeField] private float vertical; // z eksenindeki hareketi tutacak (z on arka)

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
}
