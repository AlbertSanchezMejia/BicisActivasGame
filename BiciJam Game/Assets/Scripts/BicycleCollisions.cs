using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BicycleCollisions : MonoBehaviour
{
    public GameObject victoria;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Persona"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
        if (col.gameObject.CompareTag("Meta"))
        {
            victoria.SetActive(true);
        }
    }
}
