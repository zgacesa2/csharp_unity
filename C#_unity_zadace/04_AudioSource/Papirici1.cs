using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Napiši kako pozivamo metodu za nalaženje Transform komponente objekta koji se zove keks

public class Papirici1 : MonoBehaviour
{
    //ova skripta se nalazi na objektu koji se zove keks
    public Transform keksTransform;

    private void Start()
    {
        keksTransform = GetComponent<Transform>();
    }
}
