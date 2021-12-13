using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyScript : MonoBehaviour
{
    [SerializeField]
    public string destroyCol;
    public string nameResetScene;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(destroyCol))
        {
            

            if (gameObject.CompareTag("Player"))
            {

                SceneManager.LoadScene(nameResetScene);
            }
            Destroy(gameObject);
        }
    }
}
