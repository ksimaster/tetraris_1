using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneMoveScript : MonoBehaviour
{
    private float rotateZ = 1f;
    public float rotateSpeed = 7f;
    private float rightForce = 0.6f;
    public string collisionTag;
   // public string collisionTagSelf;
    public float timeLife;



    void FixedUpdate()
    {
       // transform.Translate(0.016f, 0, 0);
        transform.Rotate(new Vector3(0, 0, rotateZ), rotateSpeed);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(rightForce, 0);
    }
  
    

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag(collisionTag))
        {
            rotateZ = 0;
            rightForce = 0;
            Invoke("DestroyBone", timeLife);
        }


    }

   public void DestroyBone()
    {
        Destroy(gameObject);
    }


}
