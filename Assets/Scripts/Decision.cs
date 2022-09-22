using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decision : MonoBehaviour
{
    int maxSpeed = 135;
    void Start()
    {
        if(maxSpeed==120)
        {
            Debug.Log("Velocidad maxima!");
        }
        else if(maxSpeed>120)
        {
            Debug.LogError("Exceso de velocidad!!");
        }
        else if(maxSpeed>=1 && maxSpeed<120)
        {
            Debug.Log("Velocidad aceptable");
        }
        else if(maxSpeed == 0)
        {
            Debug.Log("Estas detenido");
        }
        else
        {
            Debug.LogError("Velocidad no permitida.");
        }


        if(EnterTheParty(15,25))
        {
            Debug.Log("Bienvenido a la fiesta");
        }
        else
        {
            Debug.Log("No tienes permiso para entrar");
        }
    }

    void Update()
    {
        
    }

    bool EnterTheParty(int age, int money)
    {
        if(age >= 18 && money>= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
