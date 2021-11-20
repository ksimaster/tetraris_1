using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField]
    float speed = 2.5f;

    private void FixedUpdate()
    {
        direction = Vector2.zero; // (0, 0)
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // (-1, 0)
            direction = Vector2.left;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // (1, 0)
            direction = Vector2.right;

        direction *= speed;
        gameObject.GetComponent<Rigidbody2D>().velocity = direction;
    }


}
