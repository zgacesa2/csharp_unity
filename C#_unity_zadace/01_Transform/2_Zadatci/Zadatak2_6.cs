using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Napravite skriptu da se kocka i sfera povećavaju i smanjuju 
 * za 3 do maksimalno 25 i minimalno 1 po sve 3 osi. 
 * Neka se kocka stalno rotira po javnim vrijednostima po sekundi, 
 * kada se kocka smanjuje smjer rotacije se promjeni.
 */

public class Zadatak2_6 : MonoBehaviour
{
    public float changeXYZ = 3;
    public float rotateX;
    public float rotateY;
    public float rotateZ;

    [Header("Ako je false onda je kocka, ako je true onda je sfera")]
    public bool sfera = false; //Ako je false onda je kocka, ako je true onda je sfera
    bool expand = true;

    private void Update()
    {
        if (transform.localScale.x <= 1 || transform.localScale.y <= 1 || transform.localScale.z <= 1)
        {
            expand = true;
        }
        else if (transform.localScale.x >= 25 || transform.localScale.y >= 25 || transform.localScale.z >= 25)
        {
            expand = false;
        }

        if (expand)
        {
            transform.localScale += new Vector3(3, 3, 3) * Time.deltaTime;
            if(sfera == false)
            {
                transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime);
            }
        }
        else
        {
            transform.localScale -= new Vector3(3, 3, 3) * Time.deltaTime;
            if (sfera == false)
            {
                transform.Rotate(new Vector3(-rotateX, -rotateY, -rotateZ) * Time.deltaTime);
            }
        }

    }
}
