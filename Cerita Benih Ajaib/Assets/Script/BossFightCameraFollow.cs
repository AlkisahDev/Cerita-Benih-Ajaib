using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightCameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject soal;
    private Vector3 offset = new Vector3(0, 0, -10);
    private Vector3 velocity = Vector3.zero;
    private float smoothTime = 0.25f;
    float timer = 0;

    [SerializeField] private Transform target;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Camera Panning Boss
        if (timer >= 6)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

            soal.SetActive(true);
        }
    }
}
