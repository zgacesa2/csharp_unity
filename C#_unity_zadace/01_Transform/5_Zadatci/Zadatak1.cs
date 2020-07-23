using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// DZ_POJEDINACNO
// 1) Napišite koju vrijednost u C# jeziku imaju sljedeći izrazi:

public class Borna_Zadatak_5_1 : MonoBehaviour
{
    public void Start()
    {
        // a)
        Debug.Log(2 + 8 * 3); // 26

        // b)
        Debug.Log(8 * (3 + 2)); // 40

        // c)
        Debug.Log(8 / 3 + 2); // 4

        // d)
        Debug.Log(8 % 3 + 2); // 4

        // e)
        Debug.Log(31 % 4 + 9 * 2); // 3 + 18 = 21

        // f)
        Debug.Log(9 * (2) + 2); // 18 + 2 = 20

        // g)
        //Debug.Log(9 / (4 >= 2 + 2)); //COMPILE TIME ERROR -> int with bool -> 9 je int, 4 <= 2 je bool

        // h)
        //Debug.Log(9 * !3 + 2); // Compile Time Error -> ! can't be used with int
    }
    
}
