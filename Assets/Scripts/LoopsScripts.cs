using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsScripts : MonoBehaviour
{

    void Start()
    {
        /*

		foreach(Type elementName in collection)
		{
			//codigo del bucle
		}

        */
        List<string> studentNames = new List<string>();
        studentNames.Add("Christian");
        studentNames.Add("Kate");
        studentNames.Add("Mia");
        studentNames.Add("Anastasia");
        studentNames.Add("Alicia");

        Debug.Log("Imprimiendo con FOREACH");
        foreach (string person in studentNames)
        {
        	Debug.Log(person);
        }

        int[] someInts = new int[] {4,8,2,9,0,7,3,1,6,5};
        int sum = 0;
        int n = someInts.Length;


        
        foreach (int number in someInts)
        {
        	sum = sum + number;
        	Debug.Log("La suma vale: " + sum);
        }

        Debug.Log("La media de los numeros es: " + sum/n);



        /*

		for (incializacion; condicion de continuacion; iterador)
		{
			//codigo del bucle
		}

        */
		Debug.Log("Imprimiendo con el FOR");
        for (int i=1; i<=10; i++)
        {
        	Debug.Log(i);
        }

        for (int j=10; j>=0; j--)
        {
        	Debug.Log(j);
        }

        for(int pos=0; pos<studentNames.Count; pos++)
        {
        	string name = studentNames[pos];
        	Debug.Log("El elemento numero "+ pos +" de la lista es "+ name);
        }



        /*
		
		//Inicializacion
		while (condicion de continuacion)
		{
			//codigo a ejecutar
			//iterador
		}

		USAR SI NO CONOCES LA CONDICION DE CONTINUACION, SI NO SABES 
		CUANTAS VECES SE EJECUTA O SI NECESITAS USAR LA VARIABLE DESPUES.

        */
		Debug.Log("BUCLE WHILE");

		int counter=1;
		while(counter<=10)
		{
			Debug.Log(counter);
			counter++;
		}


		        

		        Debug.Log("Elementos de busqueda");

        int objectPos = -1;
        for (int i=0; i<studentNames.Count; i++)
        {
        	Debug.Log("Estamos en la iteracion no. " + i);
        	if(studentNames[i] == "Mia")
        	{
        		objectPos=i;
        		break;
        	}
        }

        if (objectPos== -1)
        {
        	Debug.Log("No hemos encontrado el objeto que buscabas");
        }
        else
        {
        	Debug.Log("El objeto se encuentra en la posicion " + objectPos);
        }

    }

    public bool IsNumberEven(int number) //par = even impar = odd
		{
			int quotient = number / 2;
			int remainder = number % 2;

			if(remainder==0)
			{
				return true;
			}
			else 
			{
				return false;
			}
		}

    void Update()
    {
        
    }
}
