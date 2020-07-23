using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetSedam : MonoBehaviour
{
    public float nekaJavnaVrijednost;

    private void Start()
    {
        int i = 0;
        while (i < 20)
        {
            transform.localScale += Vector3.right;
            transform.localScale -= Vector3.up;
            transform.localScale -= Vector3.forward;
            i++;
        }
        
    }
}
