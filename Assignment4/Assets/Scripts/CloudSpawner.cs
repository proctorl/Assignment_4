using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public Cloud cloudTemplate;

    public Vector2 spawnHeight = new Vector2(3, 4);
    public float SpawnFrequency = 2;
    public float SpawnWidth = 200;

    private float lastSpawn = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (lastSpawn >= SpawnFrequency)
        {
            var cloud = Instantiate(cloudTemplate, transform, false);
            cloud.Initialize();


            var y = Random.Range(-5, 5);
            cloud.transform.position = new Vector3(12, y, 1);

            lastSpawn = 0;
        }
        else
        {
            lastSpawn += Time.fixedDeltaTime;
        }

    }
  
}
