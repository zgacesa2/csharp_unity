using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube1")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
