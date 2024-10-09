using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float speed;

    private void FixedUpdate()
    {
        Vector3 start = transform.position;
        Vector3 goal = player.transform.position + (player.transform.up * offset);
        Vector3 path = goal - start;
        Vector3 movement = path.normalized * speed;
        transform.position += movement;
    }
}
