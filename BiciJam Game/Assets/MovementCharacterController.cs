using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacterController : MonoBehaviour
{
    public float movementSpeed;
    CharacterController controller;
    Vector3 moveDirection;
    int gravityScale = 1;

    void Start()
    {
        controller = GetComponent<CharacterController>();   
    }

    void FixedUpdate()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");
        moveDirection = new Vector3(xMovement * movementSpeed, moveDirection.y, zMovement * movementSpeed);

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);

        controller.Move(moveDirection * Time.deltaTime);
    }
    
}
