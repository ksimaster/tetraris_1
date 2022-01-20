using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeoutStartScript : MonoBehaviour
{
    public GameObject TimeoutObject;

   /* IEnumerator Timeout()
    {
        yield return new WaitForSeconds(10f);
    }
    */
    public void OnStart()
    {
        
      //  StartCoroutine("Timeout");
       

        TimeoutObject.SetActive(true);
      /*  for (int i=1; i<10; i++)
        {
            if (i % 2 == 0)
            {
                
                TimeoutObject.SetActive(false);
                
                StartCoroutine("Timeout");
                

            }
            else
            {
                TimeoutObject.SetActive(true);
                StartCoroutine("Timeout");
            }
        }
        TimeoutObject.SetActive(true); */
    }


}
