using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour {
    public Transform firePoint;
    public GameObject tonguePrefab;

    public float bulletForce = 20f;

    void Update() {
        if(Input.GetButtonDown("Fire2")) {
            Shoot();
        }
    }

    void Shoot() {
        GameObject tongue = Instantiate(tonguePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigidBody = tongue.GetComponent<Rigidbody2D>();
        rigidBody.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}