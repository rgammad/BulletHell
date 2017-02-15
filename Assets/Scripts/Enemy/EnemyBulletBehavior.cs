using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class EnemyBulletBehavior : MonoBehaviour, ISpawnable {

    [SerializeField]
    protected float speed = 5.0f;
    [SerializeField]
    protected float damage = 5f;

    void OnCollisionEnter2D(Collision2D other)
    {
        Health targetHealth = other.transform.root.GetComponent<Health>();
        if (targetHealth != null)
        {
            targetHealth.Damage(damage);
        }
        BetterPool.Despawn(this.gameObject);
    }

    void ISpawnable.Spawn()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1 * speed);
    }
}
