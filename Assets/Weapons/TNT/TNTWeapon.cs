using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTWeapon : Weapon
{
    public float attackSpeed = 100f;
    public GameObject tnt;
    private GameObject player;
    public GameObject explosion;
    public float explodeDelay = 1;
    public float explodeDurration = 0.5f;
    private int counter = 0;
    private IEnumerator coroutine;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       counter++;
        
        if (counter == attackSpeed)
        {
            GameObject newTnt = GameObject.Instantiate(tnt);
            newTnt.transform.position = player.transform.position;
            newTnt.SetActive(true);

            Destroy(newTnt, explodeDelay);

            StartCoroutine(Wait(explodeDelay, newTnt.transform.position));
           

            counter = 0;
        }

        
    }

    private IEnumerator Wait(float waitTime, Vector3 pos)
    {
        yield return new WaitForSecondsRealtime(waitTime);
        print("no");

        GameObject newExplosion = GameObject.Instantiate(explosion);
        newExplosion.transform.position = pos;
        newExplosion.SetActive(true);

        Destroy(newExplosion, explodeDurration);
    }
}
