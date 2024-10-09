using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public Transform goal;
    public float speed;

    private void FixedUpdate()
    {
        Vector3 start = transform.position;
        Vector3 path = goal.position - start;
        Vector3 movement = path.normalized * speed;
        transform.position += movement;
    }
}
