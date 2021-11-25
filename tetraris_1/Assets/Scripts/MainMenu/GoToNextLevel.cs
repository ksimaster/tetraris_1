using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("Player"))
        {
            UnLockLevel();
            SceneManager.LoadScene(1);
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

}
