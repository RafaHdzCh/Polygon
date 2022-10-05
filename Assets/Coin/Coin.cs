using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour

{
	public static int coinsCount = 0;
    [SerializeField] TextMeshProUGUI coinsCollected;
    [SerializeField] AudioSource coinSound;

    void Start()
    {
		coinsCount++;
    }

    void Update()
    {
        coinsCollected.text = coinsCount.ToString();
    }

    private void OnTriggerEnter (Collider otherCollider)
    {
    	if (otherCollider.CompareTag("Player")==true)
    	{
            coinSound.Play();
            coinsCount--;
    			if (coinsCount==0)
    			{
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
