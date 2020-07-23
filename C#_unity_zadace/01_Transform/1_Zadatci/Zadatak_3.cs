using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Rotirajte kocku za javnu vrijednost po sve tri osi svake sekunde

public class Zadatak_3 : MonoBehaviour
{
    public float sveRotation;

    public void Update()
    {
        transform.Rotate(Vector3.one * Time.deltaTime * sveRotation);
    }
}
