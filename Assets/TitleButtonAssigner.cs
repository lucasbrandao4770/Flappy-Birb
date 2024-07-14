using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleButtonAssigner : MonoBehaviour
{
    public Button startGameButton;
    public Button optionsGameButton;
    public Button quitGameButton;
    private void Start()
    {
        // Ensure buttons are assigned correctly
        if (startGameButton != null)
            startGameButton.onClick.AddListener(() => LogicScript.Instance.StartGame());

        if (optionsGameButton != null)
            optionsGameButton.onClick.AddListener(() => LogicScript.Instance.OptionsMenu());

        if (quitGameButton != null)
            quitGameButton.onClick.AddListener(() => LogicScript.Instance.QuitGame());
    }
}
