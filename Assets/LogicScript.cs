using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public GameObject gameOverScreen;



    [ContextMenu("Increase Score")]
    public void addScore(int score)
    {
        playerScore += score;
        scoreText.text = playerScore.ToString();
    }


    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playerScore = 0;
        scoreText.text = "0";
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
