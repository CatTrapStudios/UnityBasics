﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private const float SPEED = 2.5f;

    public UIController UI;
    public AudioSource jumpSound;
    public AudioSource hitSound;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 position = transform.position;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= SPEED * Time.deltaTime;
            animator.SetBool("walking", true);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            position.x += SPEED * Time.deltaTime;
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }

        transform.position = position;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") ||
               animator.GetCurrentAnimatorStateInfo(0).IsName("Move") ||
               animator.GetNextAnimatorStateInfo(0).IsName("Idle") ||
               animator.GetCurrentAnimatorStateInfo(0).IsName("Move"))
            {
                animator.SetTrigger("jump");
                jumpSound.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        UI.ArrowHitPlayer();
        hitSound.Play();
    }
}