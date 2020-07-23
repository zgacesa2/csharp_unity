using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Napravite capsulu na sceni i stavite joj tag heal.
 * Imajte tri javne vrijednosti za health, health regen i dmg.
 * Kada uđete u sferu primate dmg jednom, a dok ste unutra
 * "dmg * Time.deltaTime". Kada uđete u capsulu primite dmg/2,
 * ali dok ste unutra primate "healthRegen * Time.deltaTime".
 * (možete imati više skripti ako smatrate potrebnim)
 */

public class Zadatak5 : MonoBehaviour
{
    public float health;
    public float healthRegen;
    public float dmg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sfera")
        {
            health -= dmg;
        }
        if (other.gameObject.tag == "Heal")
        {
            health -= dmg * 0.5f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Sfera")
        {
            health -= dmg * Time.deltaTime;
        }

        if (other.gameObject.tag == "Heal")
        {
            health += healthRegen * Time.deltaTime;
        }
    }
}
