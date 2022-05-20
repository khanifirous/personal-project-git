using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody rb;
    public Transform firePoint;

    void Update()
    {
        rb.AddForce(firePoint.forward * bulletSpeed, ForceMode.Impulse); 
    }
}
