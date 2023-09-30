using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Run", true);
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Run", false);
        }
    }
}
