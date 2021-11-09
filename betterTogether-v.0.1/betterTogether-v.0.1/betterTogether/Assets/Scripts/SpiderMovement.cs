using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour
{
    
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 10f;


    void Update()
    {
        float steerAmount = Input.GetAxis("p2Horizontal") * steerSpeed * Time.deltaTime;
        // Determines how much the Spider will turn after pressing one of the
        //  left or right movement keys.

        float moveAmount = Input.GetAxis("p2Vertical") * moveSpeed * Time.deltaTime;

        // Determines how much the Spider will move after pressing one of the
        //  up or down movement keys.

        transform.Rotate(0, 0, -steerAmount);
        // Actually rotates Spider using steerAmount calculation ^^

        transform.Translate(0, moveAmount, 0);
        // Actually moves Spider forward or back using moveAmount calculation ^^
    }
}
