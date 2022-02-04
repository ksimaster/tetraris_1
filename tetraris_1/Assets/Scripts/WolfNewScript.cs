using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfNewScript : MonoBehaviour
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
    public GameObject legs;
    public GameObject head;
    public Vector2 legsPosition;
    public Vector2 headPosition;

    private bool isJumping;

    private void Awake()
    {
        legsPosition = new Vector2(legs.transform.localPosition.x, legs.transform.localPosition.y);
        headPosition = new Vector2(head.transform.localPosition.x, head.transform.localPosition.y);
    }

    private void FixedUpdate()
    {
        animatorWolf.SetBool("isGrounded", groundDetection.isGrounded);
        isJumping = isJumping && !groundDetection.isGrounded;
        animatorWolf.SetBool("toJump", isJumping);
        if (!isJumping)direction = Vector2.zero; // (0, 0) || добавлена проверка на наличие прыжка
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            isJumping = false;
            animatorWolf.SetBool("toJump", isJumping);
            direction = Vector2.left; // (-1, 0)
            animatorWolf.SetBool("toWalk", true);
            Flip();
            soundSteps.GetComponent<AudioSource>().mute = false; // Нет проверки на общее отключение звука
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            isJumping = false;
            animatorWolf.SetBool("toJump", isJumping);
            direction = Vector2.right;// (1, 0)
            animatorWolf.SetBool("toWalk", true);
            Flip();
            soundSteps.GetComponent<AudioSource>().mute = false; // Нет проверки на общее отключение звука
        }

        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) && groundDetection.isGrounded)
        {
            rigidbodyWolf.AddForce(new Vector2(0, force));//(transform.up * force, ForceMode2D.Impulse); с использованием force mode
            // animatorWolf.SetTrigger("StartJump");
            isJumping = true;
            animatorWolf.SetBool("toJump", isJumping);
            
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
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            if(legs.transform.localPosition.x != legsPosition.x && head.transform.localPosition.x != headPosition.x) { 
                gameObject.transform.position = new Vector2(gameObject.transform.position.x + 0.6f, gameObject.transform.position.y);
                legs.transform.localPosition = legsPosition;
                head.transform.localPosition = headPosition; 
            }
        }
            
        if (direction.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            if(legs.transform.localPosition.x == legsPosition.x && head.transform.localPosition.x == headPosition.x) { 
                gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.6f, gameObject.transform.position.y);
                legs.transform.localPosition = new Vector2(legs.transform.localPosition.x + 0.634f, legs.transform.localPosition.y);
                head.transform.localPosition = new Vector2(head.transform.localPosition.x + 0.289f, head.transform.localPosition.y);
            }
        }
            
    }


}
