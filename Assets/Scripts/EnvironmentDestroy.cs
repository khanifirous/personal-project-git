using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Gun"))
        {
            Destroy(other.gameObject); 
        }
    }
}
