using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public GameObject backgroundSound;
    public GameObject stepsSound;
   // public GameObject clickSound;
    public GameObject ButtonOn;
    public GameObject ButtonOff;
    int On;

    private void Start()
    {
        if (PlayerPrefs.HasKey("On"))
        {
           On = PlayerPrefs.GetInt("On", On);
            if (On == 0)
            {
                backgroundSound.GetComponent<AudioSource>().mute = true;
                stepsSound.GetComponent<AudioSource>().mute = true;
                //clickSound.GetComponent<AudioSource>().mute = true;
                ButtonOn.SetActive(false);
                ButtonOff.SetActive(true);
            }
            else
            {
                backgroundSound.GetComponent<AudioSource>().mute = false;
                stepsSound.GetComponent<AudioSource>().mute = false;
                //clickSound.GetComponent<AudioSource>().mute = false;
                ButtonOn.SetActive(true);
                ButtonOff.SetActive(false);
            }
        }
    }

    public void SoundOff()
    {
        backgroundSound.GetComponent<AudioSource>().mute = true;
        stepsSound.GetComponent<AudioSource>().mute = true;
        //clickSound.GetComponent<AudioSource>().mute = true;
        On = 0;
        PlayerPrefs.SetInt("On", On);
    }

    public void SoundOn()
    {
        backgroundSound.GetComponent<AudioSource>().mute = false;
        stepsSound.GetComponent<AudioSource>().mute = false;
        //clickSound.GetComponent<AudioSource>().mute = false;
        On = 1;
        PlayerPrefs.SetInt("On", On); 
    }

}
