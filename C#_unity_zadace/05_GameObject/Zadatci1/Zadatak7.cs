using System;
using UnityEngine;

/// <summary>
/// 7.) Napravite objekt koji se krece iskljucivo lijevo ili desno (Z os) na tipke strelice left arrow i right arrow.
/// Kada dotakne sferu neka se ugasi sfera i aktiviraju sve kapsule, a kada dotakne jednu kapsulu neka ugasi sve kapsule koje jesu aktivne.
/// Cilj je ugasiti sve objekte na sceni. Imajte 4 kapsule i 2 sfere (sve su naravno na jednakoj Y i X osi)
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class ActiveExercise23_07_07 : MonoBehaviour
{

    private const string SphereTag = "Sphere";
    private const string CapsuleTag = "Capsule";

    public float forceValue = 40f;

    public GameObject[] spheres;
    public GameObject[] capsules;

    private Rigidbody body;
    private Vector3 force = Vector3.zero;



    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        force = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            force = Vector3.forward * -forceValue;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            force = Vector3.forward * forceValue;
        }
    }

    private void FixedUpdate()
    {
        body.AddForce(force);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"touched other= {other}");

        if (other.CompareTag(SphereTag))
        {
            other.gameObject.SetActive(false);
            // ActivateCapsules();
        }
    }

}
