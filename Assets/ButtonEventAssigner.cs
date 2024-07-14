using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventAssigner : MonoBehaviour
{
    public SceneManagerScript sceneManager;
    public Button playAgainButton;
    public Button optionsButton;
    public Button startMenuButton;
    public Button restartButton;
    public Button resumeButton;

    private void Awake()
    {
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManagerScript>();

        if (playAgainButton != null)
            playAgainButton.onClick.AddListener(sceneManager.RestartGame);

        if (optionsButton != null)
            optionsButton.onClick.AddListener(sceneManager.OptionsMenu);

        if (startMenuButton != null)
            startMenuButton.onClick.AddListener(LogicScript.Instance.StartMenu);

        if (restartButton != null)
            restartButton.onClick.AddListener(sceneManager.RestartGame);

        if (resumeButton != null)
            resumeButton.onClick.AddListener(sceneManager.PauseMenu);
    }
}
