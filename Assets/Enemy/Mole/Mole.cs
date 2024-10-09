using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public GameObject player;
    private Vector3 goal;
    public int attackSpeed = 20;
    public int delay = 5;
    private int counter = 0;

    private void FixedUpdate()
    {
        counter++;
        if (counter == delay)
        {
            goal = player.transform.position;
        }

        if (counter == delay + attackSpeed)
        {
            transform.position = goal;
            counter = 0;
        }
    }
}
