using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindUpScript : MonoBehaviour
{
    public float forceWind;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forceWind));
        }
    }
}
