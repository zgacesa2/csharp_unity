using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1. Zadatak
// Rotirajte kocku za 1 stupanj svaki frame
//a.) Po X osi
//b.) Po Y osi
//c.) Po Z osi
public class Transform_All : MonoBehaviour
{
    public float speedX;
    public float speedY;
    public float speedZ;

    private void Update()
    {
        //a.)
        transform.Rotate(Vector3.right * speedX);
        //b.)
        transform.Rotate(Vector3.up * speedY);
        //c.)
        transform.Rotate(Vector3.forward * speedZ);
    }
}
