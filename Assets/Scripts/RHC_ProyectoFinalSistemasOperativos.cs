using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;

public class RHC_ProyectoFinalSistemasOperativos : MonoBehaviour
{
    /*

        Proyecto final. Funcionamiento de los procesos en la memoria RAM.
        Hecho por Rafael Hernandez Chavez utilizando el lenguaje de pro-
        gramacion C# y compilado en Unity para ser visualizado mediante 
        la consola.

        Lista de Acciones:
        Pulsar C: Cerrar un Programa.
        Pulsar O: Abrir un Programa.
        Pulsar R: Reiniciar memoria ram. 
        Pulsar N: Nombrar celdas.
        Pulsar E: Calcular celdas vacias.
        
    */

    private List<string> nombreDePrograma = new List<string>(7);    //Declaro una lista con 7 posiciones (Cada uno es 1GB de RAM)
    private List<string> programasEnCache = new List<string>();     //Declaro una lista para los programas que se van al cache
    private int pos = 0;                                            //Iterador para saber cuantos GB de RAM se requieren
    private int ram;                                                //Inicializo la variable RAM

    private string nuevoPrograma = "Halo";                          //Ejemplo de nuevo programa que voy a querer abrir mientras uso el PC
    private int gbNecesarios = 1;                                   //Le asigno una cantidad de RAM a ese nuevo programa

    private string programaCerrado = "Photoshop";                   //Ejemplo de un programa que quiero cerrar
    private int gbProgramaCerrado;                                  //Inicializo la variable de los GB que liberara el programa que cierre.
    private string celdaVacia = "0";                                //Valor que debe tomar una celda que no esta en uso.

    private int cantidadDeCeldasVacias;                             //Contador de celdas vacias.
    private int auxiliarCache;                                      //Contador de celdas ocupadas en cache.

    void Awake() //FUNCIONA
    {
        nombreDePrograma.Add("Google");         //0
        nombreDePrograma.Add("Google");         //1
        nombreDePrograma.Add("Bloc de Notas");  //2
        nombreDePrograma.Add("Photoshop");      //3
        nombreDePrograma.Add("Photoshop");      //4
        nombreDePrograma.Add("0");              //5
        nombreDePrograma.Add("0");              //6
        nombreDePrograma.Add("0");              //7  <- En total son 8GB de RAM

        ram = nombreDePrograma.Count;           //Aqui podemos modificar la cantidad de Ram anadiendo proramas al arranque del ordenador.

        Debug.Log("La memoria RAM instalada en este ordenador tiene una capacidad de " + ram + "GB.");
        Debug.Log("La computadora ha cargado el sistema operativo.");
    }

    void Start() //FUNCIONA
    {
        NombrarProgramas();
    }

    void Update() //FUNCIONA
    {
        if(Input.GetKeyDown(KeyCode.C)) //Si se presiona la tecla "x", entonces se ejecuta el metodo "x".
        {
            CerrarUnPrograma();
        }
        if(Input.GetKeyDown(KeyCode.O)) //Si se presiona la tecla "x", entonces se ejecuta el metodo "x".
        {
            AbrirUnPrograma();
        }
        if(Input.GetKeyDown(KeyCode.N)) //Si se presiona la tecla "x", entonces se ejecuta el metodo "x".
        {
            NombrarProgramas();
        }
        if(Input.GetKeyDown(KeyCode.R)) //Si se presiona la tecla "x", entonces se ejecuta el metodo "x".
        {
            ReiniciarMemoriaRAM();
        }
        if(Input.GetKeyDown(KeyCode.E)) //Si se presiona la tecla "x", entonces se ejecuta el metodo "x".
        {
            CalcularCeldasVacias();
        }
    }

    void NombrarProgramas() //FUNCIONA
    {
        Debug.Log("Los programas que el usuario esta usando son: ");
        foreach (string programa in nombreDePrograma)                                               //Por cada elemento en la lista nombreDePrograma[]...
        {
            if(pos<ram && nombreDePrograma[pos]!=celdaVacia)                                        //Si la posicion del elemento es menor que el tamano de la lista y el valor de la lista es diferente a "vacio"...
            {
                Debug.Log("[RAM] El programa " + programa + " se encuentra en la posicion " + pos);
            }
            else
            {
                Debug.Log("[RAM] La celda " + pos + " se encuentra vacia.");                        //De lo contrario, la celda se encuentra vacia.
            }
            pos++;
        }
        pos=0;

        foreach (string cache in programasEnCache)  //Por cada elemento en la lista nombreDePrograma[]...  
        {
            auxiliarCache++;                        //Aumento el contador de celdas ocupadas en cache.
        }
        Debug.Log("[CACHE] Actualmente el cache esta ocupando: " + auxiliarCache);
    }

    void AbrirUnPrograma()  //FUNCIONA 50%
    {
        Debug.Log("[RAM] El usuario desea abrir el programa " + nuevoPrograma);
        CalcularCeldasVacias();

        if(gbNecesarios<=cantidadDeCeldasVacias)
        {
            int iterador = 0;
            while(gbNecesarios>=cantidadDeCeldasVacias && iterador<=ram)
            {
                if(nombreDePrograma[iterador]==celdaVacia)
                {
                    nombreDePrograma[iterador]=nuevoPrograma;
                }
                iterador++;     
            }
            Debug.Log("[RAM] El usuario ha abierto el programa " + nuevoPrograma);
        }
        else if(gbNecesarios>cantidadDeCeldasVacias) //El programa necesita mas RAM de la que hay disponible
        {
            Debug.Log("[CACHE] No hay suficiente memoria RAM disponible para ejecutar el programa.");
            Debug.Log("[CACHE] El programa deseado ira a espera en la memoria cache.");
            MandarProgramaCache();  //El elemento supera las dimensiones de la lista y se manda a la lista de proramas en Cache
        }
    }

    void CerrarUnPrograma() //FUNCIONA
    {
        Debug.Log("[RAM] El usuario ha decidido cerrar el programa " + programaCerrado + ".");
        if(nombreDePrograma.Contains(programaCerrado))  //Si el nombre del programa se encuentra en la lista de programas en ejecucion...
        {
            programaCerrado = celdaVacia; //El programa que se cerro se convierte en celdas vacias.
            Debug.Log("[RAM] El programa ha sido cerrado exitosamente.");
        }
        else
        {
            Debug.Log("El programa seleccionado no se encuentra en ejecucion.");
        }
        
    }

    void CalcularCeldasVacias() //FUNCIONA
    {
        for(int i=0; i<ram; i++)
        {
            if(nombreDePrograma[i] == celdaVacia)       //Si el nombre del programa en la posicion del iterador es una celda vacia...
            {
                Debug.Log("[RAM] La celda " + i + " se encuentra vacia.");  //Entonces la nombramos como una celda vacia
                cantidadDeCeldasVacias++;                                   //y el contador de celdas vacias aumenta en 1.
            }
        }
        Debug.Log("[RAM] La cantidad de celdas vacias es  " + cantidadDeCeldasVacias);
    }    

    void MandarProgramaCache() //FUNCIONA
    {
        for(int i=0; i<=gbNecesarios; i++)      //Por cada GB de RAM que el programa requiera, se le asignara una celda por GB en la memoria Cache     
        {
            programasEnCache.Add(nuevoPrograma);//Se llena una celda nueva con informacion del nuevo programa.
            Debug.Log("[CACHE] El programa " + nuevoPrograma + " se encuentra en la posicion " + i + " de la memoria Cache");
        }
    }

    void ReiniciarMemoriaRAM()  //FUNCIONA
    {
        Debug.Log("El usuario ha decidido reiniciar el ordenador.");
        nombreDePrograma.Clear();   //Se eliminan todos los elementos de la lista pero manteniendo la cantidad de celdas (la variable ram)
        for(int i=0; i<ram; i++)    //A partir de la cuenta 0, se reemplazan los valores de la lista de programas con celdas vacias.
        {
            nombreDePrograma.Insert(i,celdaVacia);  //Se inserta en cada posicion del iterador una celda vacia.
        }
        Debug.Log("El ordenador se ha reiniciado correctamente y ahora todas las celdas estan vacias.");
    }
}