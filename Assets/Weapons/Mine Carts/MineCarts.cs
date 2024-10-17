using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class MineCarts : Weapon
{
    public GameObject cart;
    private int counter = 0;
    public float projectileSpeed = 10f;
    public float attackSpeed = 20f;

    public float projectileLifetime = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;

        if (counter == attackSpeed)
        {
            createProjectile(0);
            createProjectile(45);
            createProjectile(90);
            createProjectile(135);
            createProjectile(180);
            createProjectile(225);
            createProjectile(270);
            createProjectile(315);

            counter = 0;
        }
    }

    private void createProjectile(float degrees)
    {
        GameObject newCart = GameObject.Instantiate(cart);
        newCart.transform.position = transform.position;
        newCart.SetActive(true);
        Rigidbody2D r = newCart.GetComponent<Rigidbody2D>();
        r.velocity = Quaternion.Euler(0, 0, degrees) * transform.up * projectileSpeed;

        Destroy(newCart, projectileLifetime);
    }
}
