using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    public GameObject player;
    public GameObject projectile;
    public float projectileSpeed = 10.0f;
    public int attackSpeed = 2;
    private int counter = 0;


    void FixedUpdate()
    {
        counter++;

        if (counter == attackSpeed)
        {
            GameObject newProjectile = GameObject.Instantiate(projectile);
            newProjectile.transform.position = transform.position;
            newProjectile.SetActive(true);
            Rigidbody2D r = newProjectile.GetComponent<Rigidbody2D>();
            r.velocity = (player.transform.position - transform.position).normalized * projectileSpeed;

            counter = 0;
        }
    }
}
