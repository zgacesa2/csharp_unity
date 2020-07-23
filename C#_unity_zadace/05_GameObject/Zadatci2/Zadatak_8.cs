using System;
using UnityEngine;

public class Zadatak_8 : MonoBehaviour
{

    public GameObject prefarban;
    float sekunda;
    public int brojac;

    private void Update()
    {
        sekunda += Time.deltaTime;

        if (sekunda >= 10)
        {
            brojac++;
            Instantiate(prefarban, Vector3.zero, Quaternion.identity);
        }
    }
}
