using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelmetWeapon : Weapon
{
    public float attackSpeed = 100f;
    private int counter = 0;
    public GameObject helmet;
    public float duration = 1f;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    void FixedUpdate()
    {
        
        counter++;

        if (counter == attackSpeed)
        {
            GameObject newHelmet = GameObject.Instantiate(helmet);
            newHelmet.transform.parent = player.transform;
            newHelmet.transform.position = player.transform.position;
            newHelmet.SetActive(true);

            Destroy(newHelmet, duration);

            counter = 0;
        }

    }
}
