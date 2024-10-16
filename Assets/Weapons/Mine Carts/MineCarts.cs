using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class MineCarts : MonoBehaviour
{
    public GameObject cart;
    private int counter = 0;
    public float projectileSpeed = 10f;
    public float attackSpeed = 20f;

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;

        if (counter == attackSpeed)
        {
            GameObject newCart = GameObject.Instantiate(cart);
            newCart.transform.position = transform.position;
            newCart.SetActive(true);
            Rigidbody2D c = newCart.GetComponent<Rigidbody2D>();
            c.velocity = transform.up * projectileSpeed;


            counter = 0;
        }
    }
}
