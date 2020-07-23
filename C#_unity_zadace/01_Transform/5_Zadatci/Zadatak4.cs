using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Napišite skriptu koja će uzeti početne vrijednosti objekta na sceni 
//(njegov scale) i invertati ga (sve scale vrijednosti postaviti na minus)
public class zadatak_4 : MonoBehaviour
{
    public float xScale;
    public float yScale;
    public float zScale;
    
    void Start()
    {
        transform.localScale =new Vector3(xScale, yScale, zScale) * (-1);
    }
}
