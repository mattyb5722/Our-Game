using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGrinder : MonoBehaviour
{
    public GameObject rock;
    public float attackSpeed = 2f;
    public float attackWidth = 7f;
    public float projectileSpeed = 10f;
    private int counter = 0;
    private Vector3 rand;

    void Start()
    {
      

    }


    void FixedUpdate()
    {
        counter++;

        if (counter == attackSpeed)
        {
            GameObject newRock = GameObject.Instantiate(rock);
            rand = new Vector3(Random.Range(attackWidth * -0.5f, attackWidth * 0.5f), 0, 0);
            newRock.transform.Rotate(0f, 0f, Random.Range(0f, 360f));
            newRock.transform.position = transform.position + rand;
            newRock.SetActive(true);
            Rigidbody2D r = newRock.GetComponent<Rigidbody2D>();
            r.velocity = transform.up * projectileSpeed;

            Destroy(newRock, 1);

            counter = 0;

        }
    }
}
