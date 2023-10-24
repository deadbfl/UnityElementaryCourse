using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 movementVector;

    [SerializeField] private float horizontal; // x eksenindeki hareketi tutacak (x sag sol)
    [SerializeField] private float vertical; // z eksenindeki hareketi tutacak (z on arka)

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        movementVector = new Vector3(horizontal, 0, vertical);
        movementVector.Normalize();

        rb.MovePosition(transform.position + movementVector * speed * Time.deltaTime);
    }
}
