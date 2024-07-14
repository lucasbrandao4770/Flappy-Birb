using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    private float moveSpeed;
    public float deadZone;

    // Public properties
    public float MoveSpeed
    {
        get { return moveSpeed; }
        set
        {
            if (value >= 0)
            {
                moveSpeed = value;
            }
            else
            {
                Debug.LogWarning("MoveSpeed cannot be negative.");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
        deadZone = -45;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
