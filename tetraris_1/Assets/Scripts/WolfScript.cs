using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField]
    float speed = 2.5f;
   // bool toWalk = false;
    public Animator wolfAnimator;

    private void FixedUpdate()
    {

        direction = Vector2.zero; // (0, 0)
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        { 
            direction = Vector2.left; // (-1, 0)
            wolfAnimator.SetBool("toWalk", true);
            Flip();
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right;// (1, 0)
            wolfAnimator.SetBool("toWalk", true);
            Flip();
        }
            

        direction *= speed;
        gameObject.GetComponent<Rigidbody2D>().velocity = direction;

        if (direction == Vector2.zero)
        {
            wolfAnimator.SetBool("toWalk", false);
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
