using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField]
    float speed = 2.5f;
   // bool toWalk = false;
    public Animator animatorWolf;
    public GameObject soundSteps;
    public Rigidbody2D rigidbodyWolf;
    public float force;
    public GroundDetection groundDetection;
    private bool isJumping;

    private void FixedUpdate()
    {
        animatorWolf.SetBool("isGrounded", groundDetection.isGrounded);
        isJumping = isJumping && !groundDetection.isGrounded;
        direction = Vector2.zero; // (0, 0)
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        { 
            direction = Vector2.left; // (-1, 0)
            animatorWolf.SetBool("toWalk", true);
            Flip();
            soundSteps.GetComponent<AudioSource>().mute = false; // Нет проверки на общее отключение звука
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right;// (1, 0)
            animatorWolf.SetBool("toWalk", true);
            Flip();
            soundSteps.GetComponent<AudioSource>().mute = false; // Нет проверки на общее отключение звука
        }

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && groundDetection.isGrounded)
        {
            rigidbodyWolf.AddForce(transform.up * force, ForceMode2D.Impulse);
            animatorWolf.SetTrigger("StartJump");
            isJumping = true;
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

    public void Flip()
    {
        if (direction.x > 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        if (direction.x < 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }


}
