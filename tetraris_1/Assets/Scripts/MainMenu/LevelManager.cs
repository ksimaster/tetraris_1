using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class LevelManager : MonoBehaviour
{
    int levelUnLock;
    public Button[] buttons;

    void Start()
    {
        levelUnLock = PlayerPrefs.GetInt("levels", 0);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            
        }


        for (int j = 0; j <=levelUnLock; j++)
        {
            if (levelUnLock > buttons.Length) levelUnLock=buttons.Length-1;
            buttons[j].interactable = true;


           // Debug.Log("Максимальная кнопка: " + i);
        }
    }

    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
       
 



   
}
