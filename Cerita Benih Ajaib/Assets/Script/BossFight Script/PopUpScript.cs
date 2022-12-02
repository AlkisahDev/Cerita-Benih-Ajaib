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
        BossFightManager bossFightManager = FindObjectOfType<BossFightManager>();

        if (bossFightManager.isAnswered == true)
        {
            StartCoroutine(PopDown());
        }

        else if (bossFightManager.isAnswered == false )
        {
            StartCoroutine(PopUp());
        }
    }

    IEnumerator PopUp()
    {   
        popUp.LeanScale(Vector3.one, 1f).setEaseInOutExpo();
        yield return new WaitForSeconds(1f);
    }

    IEnumerator PopDown()
    {
        popUp.LeanScale(Vector3.zero, 0.2f).setEaseInOutExpo();
        yield return new WaitForSeconds(0.2f);
    }
}
