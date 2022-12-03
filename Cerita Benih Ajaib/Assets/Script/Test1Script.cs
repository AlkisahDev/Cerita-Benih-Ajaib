using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Script : MonoBehaviour
{
    public void DelayingLoadScene()
    {
        StartCoroutine(DelayLoadScene());
    }
    public IEnumerator DelayLoadScene()
    {
        yield return new WaitForSeconds(2f);
    }
}
