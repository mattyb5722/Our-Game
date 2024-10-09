using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public int rotationSpeed = 1;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.Rotate(Vector3.forward * rotationSpeed);

    }
}
