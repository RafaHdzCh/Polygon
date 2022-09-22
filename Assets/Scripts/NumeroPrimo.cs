using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroPrimo : MonoBehaviour
{
    void Start()
    {
        int number = 7;
        bool isPrime = true;

        for (int i =2; i<number; i++)
        {
        	if(number % i == 0)
        	{
        		isPrime = false;
        	}
        }
        if (isPrime)
        {
        	Debug.Log("El numero "+number+" es primo");
        }
        else
        {
        	Debug.Log("El numero "+number+" no es primo");
        }

        Debug.Log("Algoritmos de Busqueda.");



    }

    void Update()
    {
        
    }
}
