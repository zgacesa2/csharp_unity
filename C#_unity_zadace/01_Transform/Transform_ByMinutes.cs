using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_ByMinutes : MonoBehaviour
{
    public float xRotation = 5;

    private void Update()
    {
        transform.Rotate(Vector3.right * xRotation * Time.deltaTime);
        //DeltaTime (Time.DeltaTime) nam je izračun od framea do framea
        //Tako dobivamo 1 sekundu u metodi Update
    }
}
