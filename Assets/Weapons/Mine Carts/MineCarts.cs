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
            CreateProjectile(0);
            CreateProjectile(45);
            CreateProjectile(90);
            CreateProjectile(135);
            CreateProjectile(180);
            CreateProjectile(225);
            CreateProjectile(270);
            CreateProjectile(315);

            counter = 0;
        }
    }

    private void CreateProjectile(float degrees)
    {
        GameObject newCart = GameObject.Instantiate(cart);
        newCart.transform.position = transform.position;
        newCart.SetActive(true);
        Rigidbody2D r = newCart.GetComponent<Rigidbody2D>();
        r.velocity = Quaternion.Euler(0, 0, degrees) * transform.up * projectileSpeed;

        Destroy(newCart, projectileLifetime);
    }
}
