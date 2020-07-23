using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Neka se sfera pozicionira na poziciju 0, 12, 3.75 u početku igre

public class Zadatak_8 : MonoBehaviour
{
    float xPosition = 0f;
    float yPosition = 12f;
    float zPosition = 3.75f;

    private void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, zPosition);
    }
}
