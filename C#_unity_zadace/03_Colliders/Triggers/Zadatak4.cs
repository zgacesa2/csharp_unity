using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Napravite skritpu koja ima javnu varijablu health i 
 * javnu varijablu healthRegen. Kada kocka uđe u sferu neka primi dmg 10.
 * Kada je u sferi gubi health za "10 * Time.deltaTime", 
 * a kada izađe krene sa regeneracijom. 
 * Regeneracija je "healthRegen * Time.deltaTime"
 */

public class Zadatak4 : MonoBehaviour
{
    public float health = 100f;
    float healthRegenerationRate = 2f;
    public float MaxHealth = 100f;
    private bool regenerating = true;

    private void Start()
    {
        health = MaxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sfera")
        {
            health -= 10;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Sfera")
        {
            health -= 10 * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Sfera")
        {
            regenerating = true;
        }
    }

    private void Update()
    {
        if(regenerating == true)
        {
            health += healthRegenerationRate * Time.deltaTime;
        }
    }
}


