using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Napišite skriptu koja će imati Debug.Log() na:
//a) Awake
//b) Start
//c) Update

public class Zadatak2_3 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Ovo je Awake");
    }

    private void Start()
    {
        Debug.Log("Ovo je Start");
    }

    private void Update()
    {
        Debug.Log("Ovo je update");
    }
}
