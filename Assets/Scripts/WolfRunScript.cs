using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfRunScript : MonoBehaviour
{
    
    
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

    private bool isJumping = false;

    private void Awake()
    {
        legsPosition = new Vector2(legs.transform.localPosition.x, legs.transform.localPosition.y);
        headPosition = new Vector2(head.transform.localPosition.x, head.transform.localPosition.y);
    }

    private void FixedUpdate()
    {
        if(transform.position.y >= -3.6)
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }

        if(groundDetection.isGrounded) animatorWolf.SetTrigger("toRun");

        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))&&!isJumping)// && groundDetection.isGrounded)
        {
            animatorWolf.SetTrigger("StartJump");
            rigidbodyWolf.AddForce(new Vector2(0, force));//(transform.up * force, ForceMode2D.Impulse); с использованием force mode
       
            Invoke("Run", 0.7f);
            
        }



    }

    void Run()
    {

        animatorWolf.SetTrigger("toRun");
    }


}
