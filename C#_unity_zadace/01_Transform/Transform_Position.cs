using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Position : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public float zSpeed;

    private void Update()
    {
        transform.position += new Vector3(xSpeed, ySpeed, zSpeed);
    }
}
