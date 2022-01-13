using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeoutStartScript : MonoBehaviour
{
    public GameObject TimeoutObject;

    IEnumerator Timeout()
    {
        yield return new WaitForSeconds(10f);
    }

    public void OnStart()
    {
        Debug.Log("Старт корутины");
        StartCoroutine("Timeout");
        Debug.Log("Завершение корутины");
        StopAllCoroutines();
        Debug.Log("Остановлены все корутины");
        TimeoutObject.SetActive(true);
        for (int i=1; i<10; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Выключение объекта");
                TimeoutObject.SetActive(false);
                Debug.Log("Старт корутины в цикле");
                StartCoroutine("Timeout");
                Debug.Log("Завершение корутины в цикле");
                StopAllCoroutines();
                Debug.Log("Остановлены все корутины в цикле");
            }
            else
            {
                TimeoutObject.SetActive(true);
            }
        }
    }


}
