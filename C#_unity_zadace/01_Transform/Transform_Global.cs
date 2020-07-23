using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Global : MonoBehaviour
{
    //ove varijable služe za uređivanje veličine
    public float xScale;
    public float yScale;
    public float zScale;

    //ove varijable služe za uređivanje roatacije
    public float xRotation;
    public float yRotation;
    public float zRotation;

    //ove varijable služe za uređivanje pozicije
    public float xPosition;
    public float yPosition;
    public float zPosition;

    private void Update()
    {
        /* Rotacija objekata
         * Vector3.Up - Rotacija po Y osi u smjeru kazaljke na satu
         * Vector3.Right - Rotacija po X osi u smjeru kazljke na satu
         * Vector3.Foward - Rotacija po Z osi u smjeru kazaljke na satu
         * Suprotno
         * Vector3.Down - Rotacija po Y osi u suprotnom sjeru kazaljke na satu
         * Vector3.Left - Rotacija po X osi u suprotnom sjeru kazaljke na satu
         * Vector3.Back - Rotacija po Z osi u suprotnom sjeru kazaljke na satu
         */
        //Promjena pozicije
        transform.position += new Vector3(xPosition, yPosition, zPosition);
        //Promjena scale-a
        transform.localScale += new Vector3(xScale, yScale, zScale);
        //Promjena rotacije
        transform.Rotate(Vector3.right * xRotation);
        transform.Rotate(Vector3.up * yRotation);
        transform.Rotate(Vector3.forward * zRotation);
    }
}
