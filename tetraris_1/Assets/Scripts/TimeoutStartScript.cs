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
        Debug.Log("����� ��������");
        StartCoroutine("Timeout");
        Debug.Log("���������� ��������");
        StopAllCoroutines();
        Debug.Log("����������� ��� ��������");
        TimeoutObject.SetActive(true);
        for (int i=1; i<10; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("���������� �������");
                TimeoutObject.SetActive(false);
                Debug.Log("����� �������� � �����");
                StartCoroutine("Timeout");
                Debug.Log("���������� �������� � �����");
                StopAllCoroutines();
                Debug.Log("����������� ��� �������� � �����");
            }
            else
            {
                TimeoutObject.SetActive(true);
            }
        }
    }


}
