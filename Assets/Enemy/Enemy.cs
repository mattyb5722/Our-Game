using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float health = 100;
    public float speedMult = 1f;
    public float damage;
    public float attackCooldown;
    private float lastAttackTime;

    protected GameObject player;
    private Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        rb = GetComponent<Rigidbody2D>();
    }
    protected void moveTowardsPlayer()
    {
        Vector2 path = player.transform.position - transform.position;
        Vector2 movement = path.normalized * speedMult;
        rb.MovePosition(transform.position + (Vector3) movement);
    }

    public void hitEnemy(HitEnemyInput input)
    {
        health -= input.damage;
        transform.position += (Vector3)input.knockBack * speedMult;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }

    public class HitEnemyInput
    {
        public readonly float damage;
        public readonly Vector2 knockBack;

        public HitEnemyInput(float damage, Vector2 knockBack)
        {
            this.damage = damage;
            this.knockBack = knockBack;
        }
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (Time.time - lastAttackTime < attackCooldown)
        {
            return;
        }
        GameObject colliderGameObject = collider.gameObject;
        Player player = colliderGameObject.GetComponent<Player>();
        if (player == null)
        {
            print("player null");
            return;
        }
        player.HitPlayer(damage);

        lastAttackTime = Time.time;
    }
}
