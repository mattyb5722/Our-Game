using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{

    private void FixedUpdate()
    {
        moveTowardsPlayer();
    }
}
