using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{
	public static int coinsCount = 0; //Variable global y estatica (Una para todos)

    void Start()
    {
		Coin.coinsCount++;
        Debug.Log("El juego ha comenzado y ahora hay " + coinsCount + " monedas.");
    }

    void Update()
    {
    	
    }

    private void OnTriggerEnter (Collider otherCollider)
    {
    	if (otherCollider.CompareTag("Player")==true)
    	{
    		Coin.coinsCount--;
    		Debug.Log("El jugador ha tomado una moneda y ahora hay " + coinsCount + " monedas." );
    			if (Coin.coinsCount==0)
    			{
    				Debug.Log("El juego ha terminado.");
    				GameObject gameManager = GameObject.Find("GameManager");
    				Destroy (gameManager);
    				GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");

    					foreach(GameObject fireworks in fireworksSystem)
    					{
    						fireworks.GetComponent<ParticleSystem>().Play();
    					}
    			}
    		Destroy(gameObject);
    	}
    }
}
