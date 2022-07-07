using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnFX : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    public void HoverSound()
    {
        myFX.PlayOneShot(hoverFx);

    }

    public void clickSound()
    {
        myFX.PlayOneShot(clickFx);

    }
}
