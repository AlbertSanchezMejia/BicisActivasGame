using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeRigidbody : MonoBehaviour
{
    Rigidbody rigidBody;

    public int velocidadAlMoverse;
    Vector3 direccionDeMovimiento;

    float rotacion = 0.0f;

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

        rigidBody.velocity = (transform.forward * zMovement * velocidadAlMoverse * Time.deltaTime);
    }

    void Rotation()
    {
        rotacion += Input.GetAxis("Horizontal");

        transform.eulerAngles = new Vector3(0.0f, rotacion, 0.0f);
    }

}
