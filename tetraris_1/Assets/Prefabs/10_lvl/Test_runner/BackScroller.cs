using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScroller : MonoBehaviour
{
    
    public BoxCollider2D col;
    public Rigidbody2D rb;
    private float width;
    private float scrollspeed = -2f;
    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = col.size.x;
        col.enabled = false;

        rb.velocity = new Vector2(scrollspeed, 0);
    }

    
    void Update()
    {
        if(transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width *2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
