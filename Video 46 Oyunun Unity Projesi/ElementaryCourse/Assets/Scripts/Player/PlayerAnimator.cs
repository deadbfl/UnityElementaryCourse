using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void SetBool(string name, bool boolen)
    {
        animator.SetBool(name, boolen);
    }
}
