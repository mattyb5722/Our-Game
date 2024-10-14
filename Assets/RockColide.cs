using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockColide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        print("Rock Hit");
    }
}
