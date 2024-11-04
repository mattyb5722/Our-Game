using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickDamageWeapon : MonoBehaviour
{
    public float damage;
    public float knockbackMult;
    public float attackCooldown;
    private float lastAttackTime;
    private void OnTriggerStay2D(Collider2D collider)
    {
        print("collider check");
        if (Time.time - lastAttackTime < attackCooldown)
        {
            return;
        }
        print("time check");
        GameObject colliderGameObject = collider.gameObject;
        Enemy enemy = colliderGameObject.GetComponent<Enemy>();
        if (enemy == null)
        {
            print("enemy null");
            return;
        }
        Vector3 knockback = (collider.transform.position).normalized * knockbackMult - gameObject.transform.position;
        print(collider.gameObject.name);
        Enemy.HitEnemyInput hitInput = new Enemy.HitEnemyInput(damage, knockback);
        enemy.hitEnemy(hitInput);
        print(enemy.health);
        lastAttackTime = Time.time;
    }
}
