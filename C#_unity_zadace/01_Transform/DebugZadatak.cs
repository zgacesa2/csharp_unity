using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugZadatak : MonoBehaviour
{
    private void Start()
    {
        var pon = new Vector3(1, 2, 3) * 3.1f;
        var uto = new Vector3(12, 21, 11) * 5.22f;
        var sri = pon + uto - pon + pon;
        var cet = "pobogu" + uto + uto;
        var pet = cet + "bas" + sri;
        var sub = "ja" + sri + cet + pet;

        Debug.Log(sub);
        //ja(65.7, 115.8, 66.7)pobogu(62.6, 109.6, 57.4)(62.6, 109.6, 57.4)pobogu(62.6, 109.6, 57.4)pobogu(62.6, 109.6, 57.4)(62.6, 109.6, 57.4)bas(65.7, 115.8, 66.7)
    }
}
