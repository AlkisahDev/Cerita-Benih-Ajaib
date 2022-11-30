using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccSpawner : MonoBehaviour
{
    public GameObject acc;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;
    void Update()
    {
        if(Time.time > SpawnTime)
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
    }

    void Spawn()
    {
        float x = Random.Range(minX, maxY);
        float y = Random.Range(minY, maxY);

        Instantiate(acc, transform.position + new Vector3(x, y, 0), transform.rotation);
    }
}
