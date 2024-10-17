using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collider)
    {
        HelmetWeapon helmetWeapon = gameObject.GetComponent<HelmetWeapon>();


        GameObject colliderGameObject = collider.gameObject;
        Enemy enemy = colliderGameObject.GetComponent<Enemy>();

        if (enemy == null)
        {
            return;
        }


        Vector3 knockback = (gameObject.transform.position - collider.transform.position).normalized;

        Enemy.HitInput hitInput = new Enemy.HitInput(1f, Vector2.zero);
        enemy.hit(hitInput);
    }
}
