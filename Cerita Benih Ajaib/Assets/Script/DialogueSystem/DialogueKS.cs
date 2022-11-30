using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueKS : MonoBehaviour
{
    // semua scene
    [SerializeField] GameObject scene7A;
    [SerializeField] GameObject scene7B;
    [SerializeField] GameObject scene7C;
    [SerializeField] GameObject scene7D;
    [SerializeField] GameObject sceneEndKS;

    public GameObject noteButtonKS;
    public GameObject itemKS;
    public GameObject endGate;
    public GameObject kochengQKS;

    public int activeSceneKS = 0;

    public enum KakSandiScene
    {
        scene7A, // pertama bertemu kak sandi
        scene7B, // bertemu setelah membaca catatan
        scene7C, // ganti scene mini game
        scene7D,  // berpisah dengan kak sandi
        sceneEndKS, // dialog setelah quest selesai
    }
    public KakSandiScene currentSceneKS;

    private void Awake()
    {
        Debug.Log("Now " + currentSceneKS);
        currentSceneKS = KakSandiScene.scene7A;
        kochengQKS.SetActive(false);
    }


    private void Update()
    {
        if (activeSceneKS == 0)
        {
            currentSceneKS = KakSandiScene.scene7A;
        }
        else if (activeSceneKS == 1)
        {
            currentSceneKS = KakSandiScene.scene7B;
        }
        else if (activeSceneKS == 2)
        {
            currentSceneKS = KakSandiScene.scene7C;
        }
        else if (activeSceneKS == 3)
        {
            currentSceneKS = KakSandiScene.scene7D;
        }
        else if (activeSceneKS == 4)
        {
            currentSceneKS = KakSandiScene.sceneEndKS;
        }

        switch (currentSceneKS)
        {
            case KakSandiScene.scene7A:

                itemKS.SetActive(false);
                kochengQKS.SetActive(false);
                endGate.SetActive(true);

                StartCoroutine(DelayScene7A());
                return;

            case KakSandiScene.scene7B:

                itemKS.SetActive(false);
                kochengQKS.SetActive(false);
                endGate.SetActive(true);

                StartCoroutine(DelayScene7B());
                break;

            case KakSandiScene.scene7C:

                itemKS.SetActive(false);
                kochengQKS.SetActive(false);
                endGate.SetActive(true);

                StartCoroutine(DelayScene7C());
                break;

            case KakSandiScene.scene7D:

                itemKS.SetActive(false);
                kochengQKS.SetActive(false);
                endGate.SetActive(true);

                StartCoroutine(DelayScene7D());
                break;

            case KakSandiScene.sceneEndKS:

                itemKS.SetActive(true);
                kochengQKS.SetActive(true);
                endGate.SetActive(false);

                StartCoroutine(DelaySceneEndKS());
                break;
        }
    }

    IEnumerator DelayScene7A()
    {
        noteButtonKS.SetActive(false);
        yield return new WaitForSeconds(0.9f);
        Debug.Log("Now " + currentSceneKS);
        scene7A.SetActive(true);

        scene7B.SetActive(false);
        scene7C.SetActive(false);
        scene7D.SetActive(false);
        sceneEndKS.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene7B()
    {
        yield return new WaitForSeconds(0.9f);
        Debug.Log("Now " + currentSceneKS);
        scene7B.SetActive(true);

        scene7A.SetActive(false);
        scene7C.SetActive(false);
        scene7D.SetActive(false);
        sceneEndKS.SetActive(false);
        noteButtonKS.SetActive(true);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene7C()
    {
        yield return new WaitForSeconds(0.9f);
        scene7C.SetActive(true);

        scene7A.SetActive(false);
        scene7B.SetActive(false);
        scene7D.SetActive(false);
        sceneEndKS.SetActive(false);
        noteButtonKS.SetActive(true);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene7D()
    {
        yield return new WaitForSeconds(0.9f);
        scene7D.SetActive(true);

        scene7A.SetActive(false);
        scene7B.SetActive(false);
        scene7C.SetActive(false);
        sceneEndKS.SetActive(false);
        noteButtonKS.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelaySceneEndKS()
    {
        yield return new WaitForSeconds(0.9f);
        sceneEndKS.SetActive(true);

        scene7A.SetActive(false);
        scene7B.SetActive(false);
        scene7C.SetActive(false);
        scene7D.SetActive(false);
        noteButtonKS.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }
}
