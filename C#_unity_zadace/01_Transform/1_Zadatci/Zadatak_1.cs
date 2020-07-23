using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Rotirajte kocku za 1 stupanj svaki frame po x, y i z osima

public class Zadatak_1 : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.right);
        transform.Rotate(Vector3.up);
        transform.Rotate(Vector3.forward);
    }
}
