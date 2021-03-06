using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleRigidbody : MonoBehaviour
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
        direccionDeMovimiento = new Vector3(0, 0, zMovement);

        rigidBody.AddRelativeForce(direccionDeMovimiento * velocidadAlMoverse * Time.deltaTime);
    }

    void Rotation()
    {
        rotacion += Input.GetAxis("Horizontal") * 5;

        transform.eulerAngles = new Vector3(0.0f, rotacion, 0.0f);
    }

}
