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
    [SerializeField] float timer1;

    [SerializeField] private Transform target;
    [SerializeField] private Transform target2;
    void Update()
    {
        BossFightManager1 bossFightManager1 = FindObjectOfType<BossFightManager1>();
        timer += Time.deltaTime;

        // Camera Panning Boss
        if (timer >= timer1 && bossFightManager1.endOfStage == false)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

            soal.SetActive(true);
            //Debug.Log(transform.position);
        }

        //else if (bossFightManager.isAnswered == true)
        //{
        //    StartCoroutine(PanningNormal());
        //}

        //IEnumerator PanningNormal()
        //{
        //    yield return new WaitForSeconds(2f);
        //    Vector3 targetPosition = target2.position;
        //    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        //}
    }
}
