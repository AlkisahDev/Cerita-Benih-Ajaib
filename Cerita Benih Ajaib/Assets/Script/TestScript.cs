using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] int spawnPosX = 0;
    [SerializeField] int spawnPosY = 0;
    [SerializeField] int spawnPosZ = 0;
    [SerializeField] int maxPosY = 0;

    float timer;

    private void Start()
    {
    }

    private void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        if (this.transform.position.y < maxPosY)
            transform.position = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
    }
}
