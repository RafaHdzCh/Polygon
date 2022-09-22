using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arreglos : MonoBehaviour
{
    //Array
    public string[] students = new string[]{"Mia","Christian","Rafa","Nicko"};
    public int[] numbersOfDoors = new int[]{1,2,3,4,5,6,7,8,11};

    //Lista
    public List<string> studentNames = new List<string>();

    //Practica
    public string[] mascotas = new string[]{"Cafe","Blanco","Negra","Lucho","Moch","Enano","Tapioca","Naranja","Norris","Botas","Fiona"};
    public int[] numeros = new int[10];
    public List<string> miembrosDeLaFamilia = new List<string>();

    public ArrayList inventory = new ArrayList();
    public Hashtable personalDetails = new Hashtable();
    
    void Start()
    {
        studentNames.Add("Rafa");

        studentNames.Add("nicko");

        studentNames.Add("moi");

        studentNames.Add("edgar");

        studentNames.Add("tiki");

        studentNames.Add("sengua");


        if(studentNames.Contains("moi"))
        {
            studentNames.Remove("moi");
            Debug.Log(studentNames.ToString());
        }

        studentNames.Insert(3, "El Chapo");

        string[] studentNamesToArray = studentNames.ToArray();
        Debug.Log("El tamano del array de estudiantes es: " + students.Length);
        Debug.Log("El primer estudiante del array es: " + students[0]);

        string thirdStudent = studentNames[0];
        Debug.Log("El primer estudiante de la lista es: " + thirdStudent);
        Debug.Log("El tamano de la lista de estudiantes es: " + studentNames.Count);



        //Array de Rafa
        for(int i=0; i<numeros.Length; i++)
        {
            numeros[i] = i+10;
            Debug.Log("El valor en la posicion " + i + " del Array es " + numeros[i]);
        }
        Debug.Log("El valor en la posicion 5 del array es: " + numeros[4]);
        numeros[4] = 100;
        Debug.Log("El nuevo valor en la posicion 5 del array es: " + numeros[4]);

        //Lista de Rafa
        miembrosDeLaFamilia.Add("Rafa");        //pos0
        miembrosDeLaFamilia.Add("Maripily");    //pos1
        miembrosDeLaFamilia.Add("Mama");        //pos2
        miembrosDeLaFamilia.Add("Papa");        //pos3
        miembrosDeLaFamilia.Add("Carlos Gallo");//pos4
        miembrosDeLaFamilia.Add("Nicko");       //pos5

        foreach (var x in miembrosDeLaFamilia)
        {
            Debug.Log(x.ToString());
        }

        if(miembrosDeLaFamilia.Contains("Carlos Gallo"))
        {
            miembrosDeLaFamilia.Remove("Carlos Gallo");
        }

        Debug.Log("Maripily termino con Carlos, ahora los miembros somos: ");
        foreach (var x in miembrosDeLaFamilia)
        {
            Debug.Log(x.ToString());
        }

        miembrosDeLaFamilia.Insert(2, "Jesse");

        Debug.Log("La cantidad de miembros en la familia son: " + miembrosDeLaFamilia.Count);
        foreach (var x in miembrosDeLaFamilia)
        {
            Debug.Log(x.ToString());
        }


        inventory.Add(30);
        inventory.Add(3.1415);
        inventory.Add("Rafael Hernandez");
        inventory.Add(GameObject.FindGameObjectsWithTag("Fireworks"));

        Debug.Log(inventory[2].GetType());
        Debug.Log(inventory[3].GetType());

        personalDetails.Add("firstName",    "Rafael");
        personalDetails.Add("lastName",     "Hernandez");
        personalDetails.Add("age",          30);
        personalDetails.Add("isMarried",    false);
        personalDetails.Add("gender",       "male");

        if(personalDetails.Contains("firstName") && personalDetails.Contains("age"))
        {
            string myName = (string)personalDetails["firstName"];
            int age = (int)personalDetails["age"];
            Debug.Log(myName);
            Debug.Log(age);
        }
        else
        {
            Debug.Log("El diccionario no contiene una o mas claves que has pedido.");
        }



    }

    void Update()
    {
        
    }
}
