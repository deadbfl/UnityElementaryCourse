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
    private PlayerAnimator playerAnimator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<PlayerAnimator>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        movementVector = new Vector3(horizontal, 0, vertical);
        movementVector.Normalize();

        rb.MovePosition(transform.position + movementVector * speed * Time.deltaTime);

        if(movementVector != Vector3.zero) // Eger Hareket Vektorum 0 dan farkli ise karakterimin hareket ettigini anlarim.
        {
            //karakter hareket ediyor
            playerAnimator.SetBool("Walk", true);
        }
        else
        {
            //karakter hareket etmiyor
            playerAnimator.SetBool("Walk", false);
        }
    }
}
