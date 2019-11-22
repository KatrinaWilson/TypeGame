using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource Ding;

    public void PlaySound()
    {
        Ding.Play();
    }
}
