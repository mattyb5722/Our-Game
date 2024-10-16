using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
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
            GameObject newCart1 = GameObject.Instantiate(cart);
            newCart1.transform.position = transform.position;
            newCart1.SetActive(true);
            Rigidbody2D c1 = newCart1.GetComponent<Rigidbody2D>();
            c1.velocity = (transform.up);
            c1.velocity = c1.velocity * projectileSpeed;

            GameObject newCart2 = GameObject.Instantiate(cart);
            newCart2.transform.position = transform.position;
            newCart2.SetActive(true);
            Rigidbody2D c2 = newCart2.GetComponent<Rigidbody2D>();
            c2.velocity = (transform.up + transform.right) * (1 / Mathf.Sqrt(2f));
            c2.velocity = c2.velocity * projectileSpeed;

            GameObject newCart3 = GameObject.Instantiate(cart);
            newCart3.transform.position = transform.position;
            newCart3.SetActive(true);
            Rigidbody2D c3 = newCart3.GetComponent<Rigidbody2D>();
            c3.velocity = (transform.right);
            c3.velocity = c3.velocity * projectileSpeed;

            GameObject newCart4 = GameObject.Instantiate(cart);
            newCart4.transform.position = transform.position;
            newCart4.SetActive(true);
            Rigidbody2D c4 = newCart4.GetComponent<Rigidbody2D>();
            c4.velocity = (-transform.up + transform.right) * (1 / Mathf.Sqrt(2f));
            c4.velocity = c4.velocity * projectileSpeed;

            GameObject newCart5 = GameObject.Instantiate(cart);
            newCart5.transform.position = transform.position;
            newCart5.SetActive(true);
            Rigidbody2D c5 = newCart5.GetComponent<Rigidbody2D>();
            c5.velocity = (-transform.up);
            c5.velocity = c5.velocity * projectileSpeed;

            GameObject newCart6 = GameObject.Instantiate(cart);
            newCart6.transform.position = transform.position;
            newCart6.SetActive(true);
            Rigidbody2D c6 = newCart6.GetComponent<Rigidbody2D>();
            c6.velocity = (-transform.up - transform.right) * (1 / Mathf.Sqrt(2f));
            c6.velocity = c6.velocity * projectileSpeed;

            GameObject newCart7 = GameObject.Instantiate(cart);
            newCart7.transform.position = transform.position;
            newCart7.SetActive(true);
            Rigidbody2D c7 = newCart7.GetComponent<Rigidbody2D>();
            c7.velocity = (-transform.right);
            c7.velocity = c7.velocity * projectileSpeed;

            GameObject newCart8 = GameObject.Instantiate(cart);
            newCart8.transform.position = transform.position;
            newCart8.SetActive(true);
            Rigidbody2D c8 = newCart8.GetComponent<Rigidbody2D>();
            c8.velocity = (transform.up - transform.right) * (1 / Mathf.Sqrt(2f));
            c8.velocity = c8.velocity * projectileSpeed;

            counter = 0;
        }
    }
}
