using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeMovement : MonoBehaviour
{
    CharacterController controller;

    public int movementSpeed;

    float rot = 0.0f;
    public int turnSpeed;

    Vector3 movementDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        Movement();
        Rotation();
        Gravity();
    }

    void Movement()
    {
        float zMovement = Input.GetAxis("Vertical");
        controller.Move(transform.forward * zMovement * movementSpeed * Time.deltaTime);
    }

    void Rotation()
    {
        rot += Input.GetAxis("Horizontal") * turnSpeed;
        transform.eulerAngles = new Vector3(0.0f, rot, 0.0f);
    }
    void Gravity()
    {
        movementDirection = new Vector3(0, movementDirection.y, 0);
        movementDirection.y = movementDirection.y + (Physics.gravity.y * 1 * Time.deltaTime);
        controller.Move(movementDirection * Time.deltaTime);
    }

}
