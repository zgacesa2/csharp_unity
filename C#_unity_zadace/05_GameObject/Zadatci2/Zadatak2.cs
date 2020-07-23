using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Na tipku S uništite ovu skriptu sa objekta

public class Zadatak2 : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Destroy(this);
        }
    }
}
