using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAddforce : MonoBehaviour
{
    public int movementSpeed;
    Rigidbody rigidBody;
    Vector3 movementDirection;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");
        movementDirection = new Vector3(xMovement * movementSpeed, rigidBody.velocity.y, zMovement * movementSpeed);
        rigidBody.AddForce(movementDirection * movementSpeed * Time.deltaTime);

    }
}