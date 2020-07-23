using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// napiši skriptu za Jump

public class JumpScript : MonoBehaviour
{
    Rigidbody rb;
    public float jump;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jump);
        }
    }
}
