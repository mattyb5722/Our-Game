using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage;
    public float knockbackMult;

    private void OnTriggerEnter2D(Collider2D collider)
    {

        GameObject colliderGameObject = collider.gameObject;
        Enemy enemy = colliderGameObject.GetComponent<Enemy>();

        if (enemy == null)
        {
            return;
        }

        Vector3 knockback = (gameObject.transform.position - collider.transform.position).normalized * knockbackMult;

        Enemy.HitInput hitInput = new Enemy.HitInput(damage, knockback);
        enemy.hit(hitInput);
    }
}
