using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");
        audioSource.Play();
        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(1);
        }
    }
}
