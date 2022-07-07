using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSteps : MonoBehaviour
{
    

    public void OnSoundSteps()
    {
        gameObject.GetComponent<AudioSource>().mute = true;
    }

    public void OffSoundSteps()
    {
        gameObject.GetComponent<AudioSource>().mute = false;
    }
}
