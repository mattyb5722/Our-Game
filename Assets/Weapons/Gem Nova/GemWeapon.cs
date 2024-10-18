using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class GemWeapon : Weapon
{
    private List<GameObject> gems = new List<GameObject>();
    public float projectileSpeed = 20f;
    public float attackSpeed = 10f;
    public float projectileLifetime = 0.5f;
    private int counter = 0;
    private GameObject player;
    void Start()
    {
        foreach (Transform child in transform)
        {
            gems.Add(child.gameObject);
        }

        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;

        if (counter == attackSpeed)
        {
            SpawnGem(0);
            SpawnGem(30);
            SpawnGem(60);
            SpawnGem(90);
            SpawnGem(120);
            SpawnGem(150);
            SpawnGem(180);
            SpawnGem(210);
            SpawnGem(240);
            SpawnGem(270);
            SpawnGem(300);
            SpawnGem(330);

            counter = 0;
        }

    }

    private void SpawnGem(float degrees)
    {
        int gemNum = UnityEngine.Random.Range(0, gems.Count);
        GameObject newGem = GameObject.Instantiate(gems[gemNum]);
        newGem.transform.position = player.transform.position;
        newGem.SetActive(true);
        Rigidbody2D r = newGem.GetComponent<Rigidbody2D>();
        r.velocity = Quaternion.Euler(0, 0, degrees) * transform.up * projectileSpeed;

        Destroy(newGem, projectileLifetime);

    }

}
