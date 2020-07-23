using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Povećajte kocku za 3 u samom pokretanju igre po Y osi

public class Zadatak_6 : MonoBehaviour
{
    private void Start()
    {
        transform.localScale += Vector3.up * 3;
    }
}
