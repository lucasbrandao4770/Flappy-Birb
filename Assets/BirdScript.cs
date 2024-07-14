using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public bool birdIsAlive;

    public LogicScript logic;
    public SceneManagerScript sceneManager;

    // Start is called before the first frame update
    void Start()
    {
        logic = LogicScript.Instance;
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManagerScript>();
        birdIsAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && birdIsAlive)
        {
            sceneManager.PauseMenu();
        }

        if (logic.GetIsPaused()) { return; }

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sceneManager.GameOver();
        birdIsAlive = false;
    }
}
