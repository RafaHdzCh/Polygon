using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estudiante : MonoBehaviour
{
    public string firstName = "Rafa";
    public string lastName = "Hernandez";
    public int age = 23;
    public float height = 1.68f;
    public float weight = 49.5f;   

    void Awake()
    {
        Debug.Log("El objeto ha despertado");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
