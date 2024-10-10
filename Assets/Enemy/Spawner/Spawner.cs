using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Enemy
{
    public GameObject enemy;
    public float spawnCooldown = 50.0f;
    private float spawnCounter = 0;

    private void FixedUpdate()
    {
        spawnCounter++;

        if (spawnCounter % spawnCooldown == 0)
        {
            GameObject child = GameObject.Instantiate(enemy);
            child.transform.position = transform.position;
            child.SetActive(true);
        }
    }

}
