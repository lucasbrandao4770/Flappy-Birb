using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public PauseScript pauseSystem;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd = 1)
    {
        playerScore += scoreToAdd;
        scoreText.text =  playerScore.ToString();
    }

    [ContextMenu("Restart Game")]
    public void restartGame()
    {
        pauseSystem.SetIsPaused(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        String name = SceneManager.GetActiveScene().name;
        Debug.Log("Game Restarted" + name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
