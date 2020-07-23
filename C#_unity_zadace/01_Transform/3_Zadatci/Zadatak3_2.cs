using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Napišite skriptu koja kocku povećava ili smanjuje za javne vrijednosti u beskonaćnost

public class Zadatak3_2 : MonoBehaviour
{
    public float XScale;
    public float YScale;
    public float ZScale;
    public bool increase = false;

    private void Update()
    {
        transform.localScale += new Vector3(XScale, YScale, ZScale);
        if (increase == true)
        {
            transform.localScale += new Vector3(XScale, YScale, ZScale) * Time.deltaTime;
        }
        else
        {
            transform.localScale -= new Vector3(XScale, YScale, ZScale) * Time.deltaTime;
        }
    }
}