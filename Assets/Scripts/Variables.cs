using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

	public int numeroDeReapariciones = 30;
	public int total;
	public float fraccion;
	public int edad = 10;
	public int peso = 30;
    
    void Awake()
    {
        Debug.Log("El Objeto ha despertado.");
    }

    void Start()
    {
    	fraccion = ( (6 * 3) / (9 * 9) );
        total = numeroDeReapariciones - 5;
        Debug.Log (total);
        Debug.Log (6 + 5);
        Debug.Log (fraccion);
        Debug.Log("El Objeto ha inciado.");
    }

    void Update()
    {
    	Debug.Log("El Objeto se esta actualizando.");
        if(Input.GetKeyDown(KeyCode.Return))
        AddTwoNumbers();
    }

    void AddTwoNumbers()
    {
    	Debug.Log(edad+peso);
    }
}
