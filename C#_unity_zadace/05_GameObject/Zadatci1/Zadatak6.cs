using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//6.) Napravite kocku koja na sebi ima audiosource koji je aktivan od starta i svira. 
//Napravite skriptu s kojom kasite ili palite objekt na kojem je audio source (tipka po vašem izboru). 
//Što se događa kada se ugasi objekt, cuje li se i dalje zvuk?
public class Zadatak6 : MonoBehaviour
{
    public GameObject predmet;
    AudioSource zvuk;

    private void Start()
    {
        zvuk = GetComponent<AudioSource>();
        zvuk.Play();
    }

    private void Update()
    {
        if (predmet.activeSelf == true && Input.GetKeyDown(KeyCode.S))
        {
            predmet.SetActive(false);
        }
        else if (predmet.activeSelf == false && Input.GetKeyDown(KeyCode.S))
        {
            predmet.SetActive(true);
        }
    }
}
