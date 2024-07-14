using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenuScreen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool GetIsPaused() { return isPaused; }

    public void SetIsPaused(bool value) { isPaused = value; }

    public void pauseMenu()
    {
        isPaused = !isPaused;
        pauseMenuScreen.SetActive(isPaused);
        Time.timeScale = isPaused ? 0 : 1;
    }
}
