using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
    [SerializeField] Vector2 movement;
    [SerializeField] Joystick joy;
    [SerializeField] AudioSource stepSound;

    // void Start()
    // {
    //     PlayerPrefs.GetInt("PakDali", 0);
    // }

    // Update is called once per frame
    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        movement.x = joy.Horizontal;
        movement.y = joy.Vertical;

        if (movement.x != 0)
        {
            if (!stepSound.isPlaying)
            stepSound.Play();
        }
        else
        {
            stepSound.Stop();
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
