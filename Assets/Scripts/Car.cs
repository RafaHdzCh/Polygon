using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour

{

	public string modelo = "Tesla";
	public int numberOfWheels = 4;
	public int maxSpeed = 250;
    
    void Awake()
    {
        Debug.Log("El Objeto ha despertado.");
    }

    void Start()
    {
        Debug.Log("El Objeto ha comenzado.");
    }


    void Update()
    {
        Debug.Log("El Objeto se esta actualizando.");
    }
}
