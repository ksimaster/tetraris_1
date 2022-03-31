using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingScript : MonoBehaviour
{
    public string collectTag;
    public Text textScore;
    private int score;

    private void Start()
    {
        score = PlayerPrefs.GetInt("score"); // на старте загружаем очки
        textScore.text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag(collectTag))
        {
            score++;
            PlayerPrefs.SetInt("score", score);
            textScore.text = score.ToString();
            Destroy(col.gameObject);
            
        }


    }
}
