using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScoreUI : MonoBehaviour
{
    //goles del jugador 1
    int goalsPlayerOne;
    //goles del jugador 2
    int goalsPlayerTwo;

    public TextMeshProUGUI scoreText;

    //resetear goles
    public void ResetScore()
    {
        goalsPlayerOne = 0;
        goalsPlayerTwo = 0;
        UpdateUI();
    }
    //añadir goles
    //Crear una funcion que aumente los goles de cada jugador
    public void GoalScoredPlayerOne()
    {
        goalsPlayerOne++;
        UpdateUI();
    }
    public void GoalScoredPlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateUI();
    }
    //mostrar
    void UpdateUI()
    {
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
