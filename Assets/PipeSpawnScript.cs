using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipeObject;
    public float spawnDistance;
    public float heightOffset;
    private GameObject lastPipe;

    // Start is called before the first frame update
    void Start()
    {
        spawnDistance = 20.6f;
        heightOffset = 10;
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (getDistanceFromPipe(transform.position.x, lastPipe) > spawnDistance)
        {
            SpawnPipe();
        }
    }

    float getDistanceFromPipe(float spawnerPositionX, GameObject pipe)
    {
        return spawnerPositionX - pipe.transform.position.x;
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 newPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);

        lastPipe = Instantiate(pipeObject, newPosition, transform.rotation);
    }
}
