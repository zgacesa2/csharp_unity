using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Scale : MonoBehaviour
{
    public float xScale;
    public float yScale;
    public float zScale;

    private void Update()
    {
        transform.localScale += new Vector3(xScale, yScale, zScale);
    }
}
