using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeMoveScript : MonoBehaviour
{
    private float rotateZ = 1f;
    private float rotateSpeed = 7f;
    private float rightForce = 0.6f;
    public string collisionTag;
    public string collisionTagSelf;



    void FixedUpdate()
    {
       // transform.Translate(0.016f, 0, 0);
        transform.Rotate(new Vector3(0, 0, rotateZ), rotateSpeed);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(rightForce, 0);
    }
  
    

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag(collisionTag)||col.gameObject)
        {
            rotateZ = 0;
            rightForce = 0;
            Invoke("DestroyCone", 0.5f);
        }


    }

    public void DestroyCone()
    {
        Destroy(gameObject);
    }


}
