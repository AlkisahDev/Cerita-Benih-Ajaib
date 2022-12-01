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

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PopUp()
    {   
        popUp.LeanScale(Vector3.one, 1f).setEaseInOutExpo();
        yield return new WaitForSeconds(1f);
    }

    IEnumerator PopDown()
    {
        popUp.LeanScale(Vector3.zero, 1f).setEaseInOutExpo();
        yield return new WaitForSeconds(1f);
    }
}
