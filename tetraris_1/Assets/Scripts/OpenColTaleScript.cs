using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenColTaleScript : MonoBehaviour
{
    [SerializeField]
    public string taleCol;
    public GameObject panelTale;
    public GameObject drawController;
    public AudioSource steps;
    private bool isFirst = true;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (isFirst) { 
            if (col.gameObject.CompareTag(taleCol))
            {
                drawController.SetActive(false);
                steps.mute = true;
                panelTale.SetActive(true);
                isFirst = false;
                Time.timeScale = 0;
                gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            }
        }
    }
}
