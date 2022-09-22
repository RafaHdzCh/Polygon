using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RafaHernandezExamen : MonoBehaviour
{
    private string playerName = "Anakin";
    private int diceCount;
    private int currentRoll;

    private void FixedUpdate()
    {
        RollDice();
    }

    private void RollDice()
    {
        currentRoll =  Random.Range(1,6);
        diceCount = diceCount + currentRoll;
        Debug.Log("El jugador: " + playerName + " ha tirado el dado y obtuvo: " + currentRoll + ". Su puntuacion total es de: " + diceCount);
    }
}