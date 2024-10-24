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
        Vector3 knockback = (collider.transform.position).normalized * knockbackMult - gameObject.transform.position;
        print(collider.gameObject.name);
        Enemy.HitEnemyInput hitInput = new Enemy.HitEnemyInput(damage, knockback);
        enemy.hitEnemy(hitInput);
    }
}
