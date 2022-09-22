using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("El objeto ha despertado");
        QualitySettings. vSyncCount = 0;
        Application. targetFrameRate = 60;
    }

    void Start()
    {
        Debug.Log("El objeto ha arrancado");
    }

    void FixedUpdate()
    {

    }
}
