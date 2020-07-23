using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mute i unmute svaki frame

public class Zadatak4 : MonoBehaviour
{
    AudioSource aSource;

    private void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(aSource.mute == false)
        {
            aSource.mute = true;
        }
        else if(aSource.mute == true)
        {
            aSource.mute = false;
        }
    }
}
