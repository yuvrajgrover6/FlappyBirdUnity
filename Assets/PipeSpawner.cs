using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    private float timer;
    public float spawnRate;

    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(); 
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;

        }


    }

    public void spawnPipe()
    {
        var lowestPoint = transform.position.y - heightOffset;
        var heighestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}
