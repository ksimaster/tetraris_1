using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject drawController;

    public void TimeOn()
    {
        Time.timeScale = 1;
    }

    public void TimeOff()
    {
        Time.timeScale = 0;
    }

    public void DrawOn()
    {
        drawController.SetActive(true);
    }

    public void DrawOff()
    {
        drawController.SetActive(false);
    }

    private void Start()
    {
        TimeOff();
        DrawOff();
    }
}
