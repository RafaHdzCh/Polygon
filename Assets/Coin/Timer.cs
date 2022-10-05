using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

	public Text tiempoText;
	public float maxTime = 180.0f;
	private float countdown = 0.0f;
    [SerializeField] TextMeshProUGUI timer;

    void Start()
    {
        countdown = maxTime;
    }

    void Update()
    {
        countdown = countdown - Time.deltaTime; //Deltatime=Tiempo desde que se renderizo en pantalla el ultimo frame.
        timer.text = countdown.ToString("F0");
        if(countdown<=0)
       		{
        		Coin.coinsCount=0;
        		SceneManager.LoadScene("MainScene");
        	}
    }
}
