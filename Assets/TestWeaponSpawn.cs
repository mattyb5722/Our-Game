using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeaponSpawn : MonoBehaviour
{
    public GameObject weapon;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject newWeapon = GameObject.Instantiate(weapon);
        }     
    }
}
