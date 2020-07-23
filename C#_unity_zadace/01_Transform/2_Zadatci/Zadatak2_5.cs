using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Scejlajte kocku za:
a) 0.25 po Y osi svaki frame
b) 89 po Z osi pri pokretanju igre
c) Kada se odradio b) zadatak neka debug ispiše kolika je trenutna veličina Z osi
*/

public class Zadatak2_5 : MonoBehaviour
{
    private void Start()
    {
        //b
        transform.localScale += new Vector3(0, 0, 89);
        //c
        Debug.Log("Trenutna veličina z osi je " + transform.localScale.z);
    }
    private void Update()
    {
        //a
        transform.localScale += new Vector3(0, 0.25f, 0);
    }
}
