using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerManagerScript : MonoBehaviour
{
    public GameObject objectMove;
    void Start()
    {
        //  InvokeRepeating("CreateObjects", 1f, 1);
        /*
        Instantiate(objectMove, new Vector2(36.2f, -0.2132f), Quaternion.identity);
        Instantiate(objectMove, new Vector2(54.38f, -0.2132f), Quaternion.identity);
        */
    }

    private void FixedUpdate()
    {
        //Debug.Log(objectMove.transform.position.x);
        /*   if (gameObject.transform.position.x <= -10f)
           {
               CreateObjects();
           }
           */
        if (Input.GetKey(KeyCode.L))
        {
            CreateObjects();
        }
    }

    void CreateObjects()
    {
        Instantiate(objectMove, new Vector2(36.2f, -0.2132f), Quaternion.identity);
    }
}
