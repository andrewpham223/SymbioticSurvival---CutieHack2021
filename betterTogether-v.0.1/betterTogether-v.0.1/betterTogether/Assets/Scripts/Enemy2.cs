using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] Color32 hitEffect = new Color32 (1, 0, 1, 1);
    [SerializeField] Color32 regEffect = new Color32 (1, 0, 1, 1);
    public int health = 100;
    public GameObject deathEffect;
    public SpriteRenderer spriteRenderer;
    
    
    
    public void TakeDamage (int damage) {
        
        health -= damage;         
    
        if (health <= 0) {

            Die();
        }

    }

    void Die() {
        Destroy(gameObject);
    }    



    // Update is called once per frame
    void Update()
    {

    }
}
