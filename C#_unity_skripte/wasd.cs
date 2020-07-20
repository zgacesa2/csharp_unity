using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class wasd : MonoBehaviour
{
    Rigidbody rb;
    public int brzina;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * brzina);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * brzina);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * brzina);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * brzina);
        }
    }
}