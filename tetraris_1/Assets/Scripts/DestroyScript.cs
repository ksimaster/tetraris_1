using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    [SerializeField]
    public string destroyCol;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(destroyCol))
        {
            Destroy(gameObject);

            
        }
    }
}
