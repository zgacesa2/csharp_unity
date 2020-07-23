﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Napravite skriptu gdje se kocka povećava ili smanjuje (do maksimalno 10 i minimalno 0.1)
//po sve 3 osi i rotira po sve 3 osi uz javne varijable. 
//Opis: Efekt kao da pulsira do 10 i nazad do 0.1 pa opet do 10 pa opet do 0.1 itd.

public class Zadatak_10 : MonoBehaviour
{
    public float xRotation;
    public float yRotation;
    public float zRotation;

    public float xScale;
    public float yScale;
    public float zScale;

    bool expand = true;

    private void Start()
    {
        if(xScale > 10)
        {
            xScale = 9.9f;
        }
        if(yScale > 10)
        {
            yScale = 9.9f;
        }
        if(zScale > 10)
        {
            zScale = 9.9f;
        }
    }

    private void Update()
    {
        if (transform.localScale.x <= 0.1f || transform.localScale.y <= 0.1f || transform.localScale.z <= 0.1f)
        {
            expand = true;
        }
        else if (transform.localScale.x >= 10f || transform.localScale.y >= 10f || transform.localScale.z >= 10f)
        {
            expand = false;
        }

        if (expand)
        {
            transform.localScale += new Vector3(xScale, yScale, zScale);
        }
        else
        {
            transform.localScale -= new Vector3(xScale, yScale, zScale);
        }
        transform.Rotate(new Vector3(xRotation, yRotation, zRotation));
    }
}
