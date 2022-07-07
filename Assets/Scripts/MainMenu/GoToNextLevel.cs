using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    public AudioClip win;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = null;
            gameObject.GetComponent<AudioSource>().PlayOneShot(win);
            Invoke("OpenLevelScenes", 1.4f);
        }
    }


    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex - 1;
        Debug.Log(currentLevel);
        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel);
        }
    }

    
    //выполняется после полного просмотра рекламного ролика из рекламного скрипта
    public void ADUnlockLevel()
    {
        
        UnLockLevel();
        SceneManager.LoadScene(1);
    }

    public void OpenLevelScenes()
    {
        UnLockLevel();
        SceneManager.LoadScene(1);
    }

}
