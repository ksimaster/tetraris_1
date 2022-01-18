using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingScript : MonoBehaviour
{
    public string collectTag;
    public Text textScore;
    private int score;


    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag(collectTag))
        {
            score++;
            textScore.text = score.ToString();
            Destroy(col.gameObject);
            
        }


    }
}
