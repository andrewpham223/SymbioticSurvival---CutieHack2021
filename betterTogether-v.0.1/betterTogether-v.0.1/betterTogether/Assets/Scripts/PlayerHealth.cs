using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int maxHealth = 400;
    public int currentHealth;
    public GameObject Player;

    void Start() {
        currentHealth = maxHealth;
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy" || other.tag == "Enemy2") {
            // Player.TakeDamage(amount)

        }
    }
    
    public void TakeDamage(int amount) {
        currentHealth -= 40;

        if(currentHealth <= 0) {
            Destroy(gameObject); 
        }
    }
}