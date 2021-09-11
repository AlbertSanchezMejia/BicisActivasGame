using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Al presionar la tecla E, se carga la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

}
