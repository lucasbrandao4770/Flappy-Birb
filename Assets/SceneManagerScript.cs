using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public LogicScript logic;
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject pauseMenuScreen;

    private void Start()
    {
        logic = LogicScript.Instance;
    }

    //
    // Score
    //
    public void addScore(int scoreToAdd = 1)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    //
    // Menus and Screens
    //
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        logic.StartGame();
    }

    public void PauseMenu()
    {
        logic.SwitchPause();
        pauseMenuScreen.SetActive(logic.GetIsPaused());
    }

    public void OptionsMenu()
    {
        //TODO: Add options menu
    }
}
