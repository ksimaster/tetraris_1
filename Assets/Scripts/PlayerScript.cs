using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Vector2 direction;
    public Transform groundCheck;
    public LayerMask groundMask;
    private bool ground = false;
    private float groundRadius = 0.5f;


    public Animator animatorWolf;
    public GameObject soundSteps;
    public Rigidbody2D rigidbodyWolf;
    public float jumpForce;
    public float speed;
    private bool isJumping = false;

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }

    private void FixedUpdate()
    {
        if(!isJumping)direction = Vector2.zero; // (0, 0)
        ground = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && ground == true)
        {
            isJumping = true;
            Jump();
        }
        Walk();

    }

    public void Walk()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animatorWolf.SetBool("toWalk", true);
            direction = Vector2.left; // (-1, 0)
            Flip();
            soundSteps.GetComponent<AudioSource>().mute = false; // Нет проверки на общее отключение звука
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            animatorWolf.SetBool("toWalk", true);
            direction = Vector2.right;// (1, 0)
            Flip();
            soundSteps.GetComponent<AudioSource>().mute = false; // Нет проверки на общее отключение звука
        }

        direction *= speed;
        direction.y = rigidbodyWolf.velocity.y;
        rigidbodyWolf.velocity = direction;

        if (direction == Vector2.zero)
        {
            animatorWolf.SetBool("toWalk", false);
            soundSteps.GetComponent<AudioSource>().mute = true; // Нет проверки на общее отключение звука
        }
    }

    public void Jump()
    {
        rigidbodyWolf.AddForce(new Vector2(0, jumpForce));
    }

    public void Flip()
    {
        if (direction.x > 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        if (direction.x < 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }


}
