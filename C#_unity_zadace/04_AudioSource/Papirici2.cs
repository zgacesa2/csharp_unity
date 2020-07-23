using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Promijeni glasnocu audio sourca prema javnoj varijabli

public class Papirici2 : MonoBehaviour
{
    public float vol;
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        source.volume = vol;
    }
}
