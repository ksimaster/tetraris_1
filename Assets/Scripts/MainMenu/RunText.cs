using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RunText : MonoBehaviour
{
    public Text TextGameObject;
    private string text;
    public float speedText;

    private void Start()
    {
        text = TextGameObject.text;
        TextGameObject.text = "";
        StartCoroutine(TextCoroutine());
    }
    IEnumerator TextCoroutine()
    {
        foreach (char abc in text)
        {
            TextGameObject.text += abc;
            yield return new WaitForSeconds(speedText);
        }

    }

}


