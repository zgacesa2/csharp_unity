using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 /*2) Koji tip imaju sljedeći izrazi (koja je vrsta varijable):

int i;
string c;
float d;

a) c + 2.1
b) d + c
c) 3.14 * d
d) i * 3
e) c + "2"
f) d + c
g) "2" * d
h) i * "2"
*/


public class Ivan_domacaZadaca : MonoBehaviour
{
    public int i;
    public string c;
    public float d;

    private void Start()
    {
        //da bude lakse, odredit cu vrijednost varijabli

        i = 1;
        c = "Ivan";
        d = 55.5f;

        //a)
        Debug.Log(c + 2.1); //odgovor: Ivan2.1 (String)


        //b)
        Debug.Log(d + c); //odgovor: 55.5Ivan (String)


        //c)
        Debug.Log(3.14 * d); //odgovor: 174.27 (Float)

        
        //d)
        Debug.Log(i * 3); //odgovor: 3 (Int)


        //e)
        Debug.Log(c + "2"); //odgovor: Ivan2 (String)


        //f)
        Debug.Log(d + c); //odgovor: 55.5Ivan (String)


        //g)
        Debug.Log("2" + d); //odgovor: 255.5 (Float)


        //h)
        Debug.Log(i * "2"); //odgovor: error
        




    }




}
