using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTanaman : MonoBehaviour
{
    [SerializeField] private GameObject tanaman1;
    [SerializeField] private GameObject tanaman2;
    [SerializeField] private GameObject tanaman3;
    [SerializeField] private GameObject tanaman4;
    [SerializeField] private GameObject tanaman5;
    [SerializeField] private GameObject tanaman6;
    [SerializeField] private GameObject tanaman7;
    [SerializeField] private GameObject tanaman8;
    [SerializeField] private GameObject tanaman9;
    [SerializeField] private GameObject tanaman10;
    [SerializeField] private GameObject tanaman11;
    [SerializeField] private GameObject tanaman12;
    [SerializeField] private GameObject tanaman13;
    [SerializeField] private GameObject tanaman14;
    [SerializeField] private GameObject tanaman15;
    [SerializeField] private GameObject tanaman16;
    [SerializeField] private GameObject tanaman17;
    [SerializeField] private GameObject tanaman18;
    [SerializeField] private GameObject tanaman19;
    float timer = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f && timer < 2f)
        {
            tanaman1.SetActive(true);
            tanaman2.SetActive(false);
            tanaman3.SetActive(false);
            tanaman4.SetActive(false);
            tanaman5.SetActive(false);
            tanaman6.SetActive(false);
            tanaman7.SetActive(false);
            tanaman8.SetActive(false);
            tanaman9.SetActive(false);
            tanaman10.SetActive(false);
            tanaman11.SetActive(false);
            tanaman12.SetActive(false);
            tanaman13.SetActive(false);
            tanaman14.SetActive(false);
            tanaman15.SetActive(false);
            tanaman16.SetActive(false);
            tanaman17.SetActive(false);
            tanaman18.SetActive(false);
            tanaman19.SetActive(false);
            Debug.Log("Tanaman1");
        }
        else if (timer >= 2f && timer < 3f)
        {
            tanaman1.SetActive(false);
            tanaman2.SetActive(true);
            tanaman3.SetActive(false);
            tanaman4.SetActive(false);
            tanaman5.SetActive(false);
            tanaman6.SetActive(false);
            tanaman7.SetActive(false);
            tanaman8.SetActive(false);
            tanaman9.SetActive(false);
            tanaman10.SetActive(false);
            tanaman11.SetActive(false);
            tanaman12.SetActive(false);
            tanaman13.SetActive(false);
            tanaman14.SetActive(false);
            tanaman15.SetActive(false);
            tanaman16.SetActive(false);
            tanaman17.SetActive(false);
            tanaman18.SetActive(false);
            tanaman19.SetActive(false);
            Debug.Log("Tanaman2");
        }
        else if (timer >= 3f && timer < 4f)
        {
            tanaman1.SetActive(false);
            tanaman2.SetActive(false);
            tanaman3.SetActive(true);
            tanaman4.SetActive(false);
            tanaman5.SetActive(false);
            tanaman6.SetActive(false);
            tanaman7.SetActive(false);
            tanaman8.SetActive(false);
            tanaman9.SetActive(false);
            tanaman10.SetActive(false);
            tanaman11.SetActive(false);
            tanaman12.SetActive(false);
            tanaman13.SetActive(false);
            tanaman14.SetActive(false);
            tanaman15.SetActive(false);
            tanaman16.SetActive(false);
            tanaman17.SetActive(false);
            tanaman18.SetActive(false);
            tanaman19.SetActive(false);
            Debug.Log("Tanaman3");
        }
    }
}
