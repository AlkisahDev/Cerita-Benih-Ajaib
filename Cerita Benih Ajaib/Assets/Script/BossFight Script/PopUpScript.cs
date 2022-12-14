using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    [SerializeField] private GameObject popUp;
    
    void Start()
    {
        popUp.transform.localScale = new Vector3(0, 0, 0);
        StartCoroutine(PopUp());
    }

    void Update()
    {
        BossFightManager1 bossFightManager1 = FindObjectOfType<BossFightManager1>();

        if (bossFightManager1.endOfStage == true
            && bossFightManager1.indexBoss == 3)
        {
            StartCoroutine(PopDown());
            bossFightManager1.endOfStage = false;
        }
        if (bossFightManager1.endOfStage == true
            && bossFightManager1.indexBoss == 6)
        {
            StartCoroutine(PopDown());
            bossFightManager1.endOfStage = false;
        }
        if (bossFightManager1.endOfStage == true
            && bossFightManager1.indexBoss == 8)
        {
            StartCoroutine(PopDown());
            bossFightManager1.endOfStage = false;
        }

        if (bossFightManager1.endOfStage == false 
            && bossFightManager1.indexBoss == 3)
        {
            StartCoroutine(PopUp());
            bossFightManager1.BossTimer();
        }
        if (bossFightManager1.endOfStage == false
        && bossFightManager1.indexBoss == 6)
        {
            StartCoroutine(PopUp());
            bossFightManager1.BossTimer();
        }
        if (bossFightManager1.endOfStage == false
           && bossFightManager1.indexBoss == 9)
        {
            StartCoroutine(PopDown());
        }
    }

    IEnumerator PopUp()
    {   
        yield return new WaitForSeconds(1f);
        popUp.LeanScale(Vector3.one, 0.5f);
    }

    IEnumerator PopDown()
    {
        popUp.LeanScale(Vector3.zero, 0.3f);
        yield return new WaitForSeconds(1f);
    }
}
