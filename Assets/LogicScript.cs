using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LogicScript : MonoBehaviour
{
    public static LogicScript Instance { get; private set; }
    private bool isPaused;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        isPaused = false;
    }

    //
    // Game Logic
    //

    public void SwitchPause() {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }

    public void PauseGame() {
        isPaused = true;
        Time.timeScale = 0;
    }

    public void UnpauseGame() {
        isPaused = false;
        Time.timeScale = 1;
    }

    //
    // Menus and Screens
    //
    public void StartMenu()
    {
        SceneManager.LoadScene("Title Menu");
    }

    public void StartGame()
    {
        UnpauseGame();
        SceneManager.LoadScene("Main Game");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void OptionsMenu()
    {
        //TODO: Add options menu
    }


    //
    // Getters
    //
    public bool GetIsPaused()
    {
        return isPaused;
    }
}
