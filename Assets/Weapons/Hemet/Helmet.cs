using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Helmet : MonoBehaviour
{
    public float rotationSpeed = 15.0f;
    void FixedUpdate()
    { 
        
        transform.Rotate(Vector3.forward * rotationSpeed);

    }

}
