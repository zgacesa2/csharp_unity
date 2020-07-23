using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Napravite skriptu koja na tipku W udara silom na objekt u smjeru X osi,
// na tipku S u negativnom smjeru X osi, na tipku A u pozitivnom smjeru Z osi,
// a na tipku D u negativnom smjeru Z osi

public class Zadatak2_5 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 3.5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.right * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.right * -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.forward * -speed);
        }
    }
}
