using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSceneScript : MonoBehaviour
{
    public float offset;
    public GameObject objectMove;

    void FixedUpdate()
    {
        // выщитываетм новую позицию объекта
        transform.position = new Vector2(transform.position.x - offset, transform.position.y);
       if (transform.position.x <= -30.5f)
        {
            Destroy(gameObject);
        }
 
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("SpawnLevel"))
        {
            Instantiate(objectMove, new Vector2(36.2f, -0.2132f), Quaternion.identity);
        }
    }
}
