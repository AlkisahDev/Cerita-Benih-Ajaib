using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTree : MonoBehaviour
{
    [SerializeField] private GameObject tree1;
    [SerializeField] private GameObject tree2;
    float timer = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f && timer < 2f)
        {
            tree1.SetActive(true);
            tree2.SetActive(false);
            Debug.Log("Tree1");
        }
        else if (timer >= 2f)
        {
            tree1.SetActive(false);
            tree2.SetActive(true);
            timer = 0f;
            Debug.Log("Tree2");
        }
    }
}
