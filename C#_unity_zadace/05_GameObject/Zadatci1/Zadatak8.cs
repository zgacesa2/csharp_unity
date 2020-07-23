using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak8 : MonoBehaviour
{
    //Napravite skriptu koja svaki frame pali/gasi objekt. Na tipku F skripta to prestaje raditi. 
    //Kada se stisne opet tipka F skripta opet o počinje raditi (obavezno koristiti vlastitu metodu)
    public GameObject predmet;
    private bool istina = true;

    private void Update()
    {
        Tipka();
        if(istina)
        {
            Pali_gasi();
        }
    }
    private void Tipka()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            istina = !istina;
        }
    }
    void Pali_gasi()
    {
       predmet.SetActive(!predmet.activeSelf);
    }
}
