using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_9 : MonoBehaviour
{

    public GameObject prefarban;
    float sekunda;
    public int brojac;

    private void Update()
    {
        sekunda += Time.deltaTime;

        if (sekunda >= 5)
        {
            brojac++;
            Instantiate(prefarban, Vector3.up * sekunda, Quaternion.identity);
        }
    }
}