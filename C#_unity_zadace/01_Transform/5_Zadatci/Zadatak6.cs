using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dz5_6: MonoBehaviour
{
    public float yzScale;

private void Start()
{
    for (int i = 0; i <= 10, i++) ;
    {
        transform.localScale -= newVector3(yzScale, yzScale, yzScale);
    }

}
}
