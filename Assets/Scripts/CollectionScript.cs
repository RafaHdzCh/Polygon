using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScript : MonoBehaviour
{
	public string student1 = "Christian";
	public string student2 = "Kate";
	public string student3 = "Mia";
	public string student4 = "Anastasia";
	int pos = 0;

	//Todas las estructuras de datos comienzan en 0

	/*
			ARRAY

		*Es homogeneo
		*Es de tamano fijo una vez creado
		*Es el cajon de los calcetines
		*Tiene un orden y se accede por posicion
	*/ 


	//Explicito
	public string[] students = new string[]{"Christian","Kate","Mia","Anastasia"}; //En el array solo se puede guardar el mismo tipo de datos.
	//Implicito
	public string[] familyNames = new string[4]; //{0,0,0,0}

	private int[] numberOfDoors = new int[5];


	/*
			LISTA

		*Es homogeneo
		*Su tamano es ajustable (Anadir/eliminar elementos en tiempo real)
		*Tiene un orden y se accede por posicion
	*/ 

	public List<string> studentNames = new List<string>();

	/*
			ARRAYLIST

		*Es heterogeneo (diferente tipo de datos en la misma estructura)
		*Su tamano es ajustable (Anadir/eliminar elementos en tiempo real)
		*Tiene un orden y se accede por posicion
	*/ 
	public ArrayList inventory = new ArrayList();


	/*
			DICCIONARIO - HASHTABLE

		*Se puede redimensionar dinamicamente (Igual que una lista)
		*Puede contener informacion heterogenea (como una ArrayList)
		*Se accede por clave, no por posicion
	*/ 

	public Hashtable personalDetails = new Hashtable();



    void Start()
    {
    	//Add = Anade un elemento al final de la lista, es como una fila de espera.
    	//Lista vacia
        studentNames.Add("Christian");
        Debug.Log(studentNames);
        //se lista tiene un elemento: christian
        studentNames.Add("Kate");
        Debug.Log(studentNames);
        //la lista tiene dos elementos: Christian, Kate
        studentNames.Add("Mia");
        Debug.Log(studentNames);
        //la lista tiene tres elementos: Christian, Kate, Mia
        studentNames.Add("Anastasia");
        Debug.Log(studentNames);
        //la lista tiene cuatro elementos: Christian, Kate, Mia, Anastasia
        studentNames.Add("Alicia");
        Debug.Log(studentNames);
        //la lista tiene cinco elementos: Christian, Kate, Mia, Anastasia, Alicia

        if(studentNames.Contains("Kate"))
        {
        	studentNames.Remove("Kate");
        }

        Debug.Log(studentNames);
        //Se elimina a Kate de la lista: Christian, Mia, Anastasia, Alicia
        studentNames.Insert(2, "Jesse");
        Debug.Log(studentNames);
        //Inserta en una posicion especifica de la lista.
        //Ahora el orden es Christian, Mia, Jesse, Anastasia, Alicia
        string[] studentNamesToArray = studentNames.ToArray(); //Se crea una copia de la lista en formato Array

        if (pos>=0 && pos<studentNamesToArray.Length)
        {
        	
        	Debug.Log("El tamano del array de estudiantes es: " + studentNamesToArray.Length);  //Length para arrays
        	Debug.Log("El primer estudiante del array es: " + students[0]); //El primer estudiante del array
    	}

    	if (pos>=0 && pos<studentNames.Count)
    	{
    		Debug.Log("El tamano de la lista de estudiantes es: " + studentNames.Count); //Count para listas
    		string thirdStudent = students[1]; //El segundo estudiante de la lista
    		Debug.Log("El cuarto estudiante de la lista es: " + thirdStudent);
    	}

        studentNames.Clear();//Clear -> Elimina definitivamente todos los elementos de la lista
        					 //Ahora la lista se encuentra vacia



        inventory.Add(30);
        inventory.Add("Juan Gabriel");
        inventory.Add(false);
        inventory.Add(3.1416);
        inventory.Add(GameObject.FindGameObjectsWithTag("Fireworks"));

        Debug.Log(inventory[2].GetType());
        Debug.Log(inventory[4].GetType());


        personalDetails.Add("firstName", "Jose");
        personalDetails.Add("lastName", "Hernandez");
        personalDetails.Add("mail", "mail@mail");
        personalDetails.Add("isMarried", false);
        personalDetails.Add("age", 30);

        string name = (string) personalDetails["firstName"];
        Debug.Log(name);
        Debug.Log(personalDetails["age"]);

        if (personalDetails.Contains("age"))
        {
        	Debug.Log(personalDetails["age"]);
        }
        else 
        {
        	Debug.Log("El diccionario no contiene las claves.");
        }



    }

    void Update()
    {
        
    }
}
