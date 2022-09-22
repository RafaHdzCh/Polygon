using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buclees : MonoBehaviour
{
    //BUCLE FOREACH
    List<string> studentNames = new List<string>();
    int[] someInts = new int[] {7,8,9,5,8,9,4,3};


    void Start()
    {

        //BUCLE FOREACH
        float sum = 0.0f;
        float n = someInts.Length;
        studentNames.Add("Christian");
        studentNames.Add("Kate");
        studentNames.Add("Mia");
        studentNames.Add("Anastasia");
        studentNames.Add("Alicia");

        foreach(string names in studentNames)
        {
            Debug.Log("Imprimiendo con FOREACH: " + names);
        }

        foreach(int i in someInts)
        {
            sum = sum+i;
            Debug.Log(i);
        }

        Debug.Log("la suma vale ahora: " + sum);
        Debug.Log("la media vale ahora: " + sum/n);
        //FIN DEL BUCLE FOREACH

        //BUCLE FOR
        Debug.Log("Bucle For");

        for(int i=1; i<=10; i++)
        {
            Debug.Log(i);
        }

        for(int i=10; i>=0; i--)
        {
            Debug.Log(i);
        }

        for(int pos=0; pos<studentNames.Count; pos++)
        {
            Debug.Log("El elemento numero " + pos + " de la lista es " + studentNames[pos]);
        }

    }

    void Update()
    {
        
    }
}
