using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGrinder : Weapon
{
    public GameObject rock;
    public float attackSpeed = 2f;
    public float attackWidth = 7f;
    public float projectileSpeed = 10f;
    private int counter = 0;
    private Vector3 rand;
    public float rockDurration = 1f;
    private GameObject sprite;

    void Start()
    {
        sprite = GameObject.FindGameObjectWithTag("Sprite");
    }


    void FixedUpdate()
    {
        counter++;

        if (counter == attackSpeed)
        {
            createProjectile();
            
            counter = 0;

        }
    }
    private void createProjectile()
    {
        GameObject newRock = GameObject.Instantiate(rock);
        newRock.transform.Rotate(0f, 0f, Random.Range(0f, 360f));
        newRock.transform.position = sprite.transform.position + (sprite.transform.right * Random.Range(attackWidth * -0.5f, attackWidth * 0.5f));
        newRock.SetActive(true);
        Rigidbody2D r = newRock.GetComponent<Rigidbody2D>();
        r.velocity = sprite.transform.up * projectileSpeed;

        Destroy(newRock, rockDurration);

    }

}
