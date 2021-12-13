using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    
    public string nameScene;

    public void ResetScene()
    {
        SceneManager.LoadScene(nameScene);
    }
}
