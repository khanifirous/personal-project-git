using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    public Rigidbody ragdollRb;

    void Start()
    {
        ragdollRb.AddForce(Vector3.forward, ForceMode.Impulse); 
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Gun"))
        {
            Destroy(other.gameObject);
        }
    }
}
