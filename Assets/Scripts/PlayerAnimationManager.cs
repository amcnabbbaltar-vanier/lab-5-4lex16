using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAnimatorController : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement movement;
    private Rigidbody rb;
    private AudioSource audioSource;


    public void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }


    public void Update()
    {
        animator.SetFloat("CharacterSpeed", rb.velocity.magnitude);
        animator.SetBool("IsGrounded", movement.IsGrounded);
       
        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetTrigger("doRoll");
        }

        if (Input.GetButtonUp("Fire2"))
        {
            animator.SetTrigger("doPunch");
            audioSource.Play();
        }
    }
}


