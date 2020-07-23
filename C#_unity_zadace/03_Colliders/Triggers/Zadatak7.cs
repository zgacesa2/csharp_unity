using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Napravite skriptu s kojom se krećete po terenu iz bočne ptičje
 * perspektive (2.5D prikaz) krećete kocku sa W, A, S i D.
 * Kada kocka dođe do jedne od 10 sfera neka joj se score poveća za jedan.
 * Kada je score 10 neka se ispiše u konzoli "pobjedio si".
 * Neka po terenu ima i capsula, ako dođete do kapsule,
 * neka vam se skine 10 hp. Ako vam hp padne na 0 ili manje
 * neka se u konzoli ispiše "umro si" (možete više skripti koristiti).
 */

public class Zadatak7 : MonoBehaviour
{
    public int score, hp;
    public float force;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        InputManager();
        Die();
    }

    private void Die()
    {
        if(hp <= 0)
        {
            Debug.Log("Umro si");
        }
    }

    private void InputManager()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * force);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sfera")
        {
            score++;
        }

        if (other.gameObject.tag == "Kapsula")
        {
            hp -= 10;
        }
    }
}
