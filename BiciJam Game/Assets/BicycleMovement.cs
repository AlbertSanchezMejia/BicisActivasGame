using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleMovement : MonoBehaviour
{
    public int movementSpeed;
    public int turnSpeed;
    Rigidbody rigidBody;
    Vector3 movementDirection;
    private float rot = 0.0f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Movement();
        Rotation();
    }

    void Movement()
    {
        float zMovement = Input.GetAxis("Vertical") * 10;
        movementDirection = new Vector3(0, 0, zMovement);
        rigidBody.AddRelativeForce(movementDirection * movementSpeed * Time.deltaTime);
    }

    void Rotation()
    {
        rot += Input.GetAxis("Horizontal") * turnSpeed;
        transform.eulerAngles = new Vector3(0.0f, rot, 0.0f);
    }

}
