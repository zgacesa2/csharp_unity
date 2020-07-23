using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePump : MonoBehaviour
{
    // transform - 5zadatci - 5zadatak Unesite neku javnu vrijednost, napravite for petlju u start metodi koja će služiti 
    // da se u svakom ponavljanju kocka poveća po x osi dok god je uvijet zadovoljen

    public int x;

    private void Start()
    {
        if(x < 0)
        {
            x *= -1;
        }
        
        for(int i = 1; x > i; i++ )
        {
            transform.localScale += new Vector3(1, 0, 0); 
        }
    }

}
