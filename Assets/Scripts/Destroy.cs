using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public ParticleSystem bloodSplat;

    void Update()
    {
        if (transform.position.y < -12)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > 30)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject); 
        }
    }
}
