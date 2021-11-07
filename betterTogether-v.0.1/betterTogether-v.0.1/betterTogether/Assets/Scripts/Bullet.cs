using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour {
    [SerializeField] public float speed = 20f;
    [SerializeField] public int damage = 50;
    public Rigidbody2D rb;
    

    void Start() {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Enemy1 enemy = hitInfo.GetComponent<Enemy1>();
        Enemy2 enemy2 = hitInfo.GetComponent<Enemy2>();
        if(enemy != null) {
            damage = 50;
            enemy.TakeDamage(damage);
        }
         if(enemy2 != null) {
            damage = 20;
            enemy2.TakeDamage(damage);
        }
        
        Destroy(gameObject);
    }
}