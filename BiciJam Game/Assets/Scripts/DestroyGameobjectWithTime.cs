using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobjectWithTime : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject);

        Destroy(gameObject, 2f);
    }
}
