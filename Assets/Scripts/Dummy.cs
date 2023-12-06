using System;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    private Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject,15f);
    }

    private void OnMouseDown()
    {
        rigidbody.AddExplosionForce(50f,rigidbody.position,10f,2f,ForceMode.Impulse);
    }
}
