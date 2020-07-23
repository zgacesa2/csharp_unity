using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Rotirajte kocku za 3 stupnja svaku sekundu:
a) Po X osi
b) po Y osi
c) Po X i Y osi
D) Kada se rotira po X i Y osi, rotira li se i po Z? - DA
*/

public class Zadatak2_4 : MonoBehaviour
{
    private void Update()
    {
        //C: oboje a + b
        //a
        transform.Rotate(new Vector3(3, 0, 0) * Time.deltaTime);
        //b
        transform.Rotate(new Vector3(0, 3, 0) * Time.deltaTime);
    }
}
