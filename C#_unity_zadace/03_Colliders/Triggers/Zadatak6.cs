using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Napravite jos jednu kocku i kopirajte ih da ih imate 10 na sceni.
 * Imajte javnu varijablu "score", kada god uđete u jednu od tih kocka
 * neka vam se score poveća za jedan.
 */

public class Zadatak6 : MonoBehaviour
{
    public int score;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="score")
        {
            score += 1;
        }
    }
}
