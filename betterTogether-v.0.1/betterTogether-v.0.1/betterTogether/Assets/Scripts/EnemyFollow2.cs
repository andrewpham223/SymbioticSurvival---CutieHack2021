using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow2 : MonoBehaviour {
    public float speed;
    public float stoppingDistance; 

    private Transform target;

    void Start () {
        target = GameObject.FindGameObjectWithTag("Player2").GetComponent<Transform>();
    }
    void Update() {
        if(Vector2.Distance(transform.position, target.position) > 0) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}