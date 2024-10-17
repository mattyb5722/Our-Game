using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D()
    {
        print("Hit");
    }
}
