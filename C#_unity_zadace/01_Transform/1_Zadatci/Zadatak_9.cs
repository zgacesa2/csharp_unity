using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Napravite skriptu koja može pomicati kocku po svim osima (javne varijable), 
//rotirati (javne varijable) i povećavati (javne varijable) svake sekunde

public class Zadatak_9 : MonoBehaviour
{
    public float xPosition;
    public float yPosition;
    public float zPosition;
    public float xRotation;
    public float yRotation;
    public float zRotation;
    public float xScale;
    public float yScale;
    public float zScale;

    private void Update()
    {
        transform.position += new Vector3(xPosition, yPosition, zPosition) * Time.deltaTime;
        transform.localScale += new Vector3(xScale, yScale, zScale) * Time.deltaTime;
        transform.Rotate(Vector3.right * xRotation * Time.deltaTime);
        transform.Rotate(Vector3.up * yRotation * Time.deltaTime);
        transform.Rotate(Vector3.forward * zRotation * Time.deltaTime);
    }
}
