using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleCollisions : MonoBehaviour
{
    public GameObject victoria;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Meta"))
        {
            victoria.SetActive(true);
        }
    }
}
