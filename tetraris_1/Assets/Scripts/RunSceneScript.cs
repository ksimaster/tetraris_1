using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSceneScript : MonoBehaviour
{
    public float offset;
    public GameObject[] objectMoves;
    public float xInstantiate;
    

    void FixedUpdate()
    {
        // ����������� ����� ������� �������
        transform.position = new Vector2(transform.position.x - offset, transform.position.y);
       /*if (transform.position.x <= -30.5f)
        {
            Destroy(gameObject);
        } */
 
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("SpawnLevel"))
        {
            Instantiate(objectMoves[Random.Range(0, objectMoves.Length)], new Vector2(xInstantiate, -0.2132f), Quaternion.identity);
            Destroy(gameObject);
        }
       
    }
}
