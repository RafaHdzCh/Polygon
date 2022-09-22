using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

	public Text tiempoText;
	public float maxTime = 300f;
	private float countdown = 0f;

    void Start()
    {
        countdown=maxTime;
    }

    void Update()
    {
        countdown=countdown-Time.deltaTime; //Deltatime=Tiempo desde que se renderizo en pantalla el ultimo frame.
        Debug.Log("Cuenta atras: " + countdown);
        if(countdown<=0)
       		{
        		Debug.Log("Te has quedado sin tiempo.");
        		Coin.coinsCount=0;
        		SceneManager.LoadScene("MainScene");
        	}
    }

    void FixedUpdate()
    {

    }
}
