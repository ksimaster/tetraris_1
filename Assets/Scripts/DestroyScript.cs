using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyScript : MonoBehaviour
{
    [SerializeField]
    public string destroyCol;
    public string nameResetScene;
    public GameObject audioSourceObject;
    public GameObject panelFinish;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(destroyCol))
        {
            

            if (gameObject.CompareTag("Player") && nameResetScene != "Level_5")
            {

                SceneManager.LoadScene(nameResetScene);
                Destroy(gameObject);
            }
            else
            {
                Time.timeScale = 0;
                audioSourceObject.GetComponent<AudioSource>().mute = true;
                
                panelFinish.SetActive(true);
            }

            if(destroyCol == "Stakes")
            {
                SceneManager.LoadScene(nameResetScene);
                Destroy(gameObject);
            }
            
        }
    }
}
