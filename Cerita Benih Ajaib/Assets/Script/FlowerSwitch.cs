using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSwitch : MonoBehaviour
{
    [SerializeField] private GameObject flower1;
    [SerializeField] private GameObject flower2;
    [SerializeField] private GameObject flower3;
    [SerializeField] private GameObject flower4;
    [SerializeField] private GameObject flower5;
    [SerializeField] private GameObject flower6;
    [SerializeField] private GameObject flower7;
    [SerializeField] private GameObject flower8;
    [SerializeField] private GameObject flower9;
    [SerializeField] private GameObject flower10;
    [SerializeField] private GameObject flower11;
    [SerializeField] private GameObject flower12;
    [SerializeField] private GameObject flower13;

    float timer = 0f;
    void Start()
    {
        
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5f && timer < 1f)
        {
            flower1.SetActive(true);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree1");
        }
        else if (timer >= 1f && timer < 1.5f)
        {
            flower1.SetActive(false);
            flower2.SetActive(true);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree2");
        }
        else if (timer >= 1.5f && timer < 2f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(true);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree3");
        }
        else if (timer >= 2f && timer < 2.5f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(true);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree4");
        }
        else if (timer >= 2.5f && timer < 3f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(true);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree5");
        }
        else if (timer >= 3f && timer < 3.5f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(true);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree6");
        }
        else if (timer >= 3.5f && timer < 4f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(true);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree7");
        }
        else if (timer >= 4f && timer < 4.5f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(true);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree8");
        }
        else if (timer >= 4.5f && timer < 5f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(true);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree9");
        }
        else if (timer >= 5f && timer < 5.5f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(true);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree10");
        }
        else if (timer >= 5.5f && timer < 6f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(true);
            flower12.SetActive(false);
            flower13.SetActive(false);
            Debug.Log("Tree11");
        }
        else if (timer >= 6f && timer < 6.5f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(true);
            flower13.SetActive(false);
            Debug.Log("Tree12");
        }
        else if (timer >= 6.5f && timer < 7f)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
            flower3.SetActive(false);
            flower4.SetActive(false);
            flower5.SetActive(false);
            flower6.SetActive(false);
            flower7.SetActive(false);
            flower8.SetActive(false);
            flower9.SetActive(false);
            flower10.SetActive(false);
            flower11.SetActive(false);
            flower12.SetActive(false);
            flower13.SetActive(true);
            timer = 0f;
            Debug.Log("Tree13");
        }
    }
}
