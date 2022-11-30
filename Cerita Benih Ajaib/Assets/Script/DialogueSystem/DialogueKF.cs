using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueKF : MonoBehaviour
{
    // semua scene
    [SerializeField] GameObject scene6A;
    [SerializeField] GameObject scene6B;
    [SerializeField] GameObject scene6C;
    [SerializeField] GameObject scene6D;
    [SerializeField] GameObject sceneEndKF;

    public GameObject noteButtonKF;
    public GameObject itemKF;
    public GameObject gate2;
    public GameObject kochengQKF;

    public int activeSceneKF = 0;

    public enum KakFloraScene
    {
        scene6A, // pertama bertemu kak flora
        scene6B, // bertemu setelah membaca catatan
        scene6C, // ganti scene mini game
        scene6D,  // berpisah dengan kak flora
        sceneEndKF, // dialog setelah quest selesai
    }
    public KakFloraScene currentSceneKF;

    private void Awake()
    {
        Debug.Log("Now " + currentSceneKF);
        currentSceneKF = KakFloraScene.scene6A;
        kochengQKF.SetActive(false);
    }


    private void Update()
    {
        if (activeSceneKF == 0)
        {
            currentSceneKF = KakFloraScene.scene6A;
        }
        else if (activeSceneKF == 1)
        {
            currentSceneKF = KakFloraScene.scene6B;
        }
        else if (activeSceneKF == 2)
        {
            currentSceneKF = KakFloraScene.scene6C;
        }
        else if (activeSceneKF == 3)
        {
            currentSceneKF = KakFloraScene.scene6D;
        }
        else if (activeSceneKF == 4)
        {
            currentSceneKF = KakFloraScene.sceneEndKF;
        }

        switch (currentSceneKF)
        {
            case KakFloraScene.scene6A:

                itemKF.SetActive(false);
                kochengQKF.SetActive(false);
                gate2.SetActive(true);

                StartCoroutine(DelayScene6A());
                return;

            case KakFloraScene.scene6B:

                itemKF.SetActive(false);
                kochengQKF.SetActive(false);
                gate2.SetActive(true);

                StartCoroutine(DelayScene6B());
                break;

            case KakFloraScene.scene6C:

                itemKF.SetActive(false);
                kochengQKF.SetActive(false);
                gate2.SetActive(true);

                StartCoroutine(DelayScene6C());
                break;

            case KakFloraScene.scene6D:

                itemKF.SetActive(false);
                kochengQKF.SetActive(false);
                gate2.SetActive(true);

                StartCoroutine(DelayScene6D());
                break;

            case KakFloraScene.sceneEndKF:

                itemKF.SetActive(true);
                kochengQKF.SetActive(true);
                gate2.SetActive(false);

                StartCoroutine(DelaySceneEndKF());
                break;
        }
    }

    IEnumerator DelayScene6A()
    {
        noteButtonKF.SetActive(false);
        yield return new WaitForSeconds(0.9f);
        Debug.Log("Now " + currentSceneKF);
        scene6A.SetActive(true);

        scene6B.SetActive(false);
        scene6C.SetActive(false);
        scene6D.SetActive(false);
        sceneEndKF.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene6B()
    {
        yield return new WaitForSeconds(0.9f);
        Debug.Log("Now " + currentSceneKF);
        scene6B.SetActive(true);

        scene6A.SetActive(false);
        scene6C.SetActive(false);
        scene6D.SetActive(false);
        sceneEndKF.SetActive(false);
        noteButtonKF.SetActive(true);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene6C()
    {
        yield return new WaitForSeconds(0.9f);
        scene6C.SetActive(true);

        scene6A.SetActive(false);
        scene6B.SetActive(false);
        scene6D.SetActive(false);
        sceneEndKF.SetActive(false);
        noteButtonKF.SetActive(true);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene6D()
    {
        yield return new WaitForSeconds(0.9f);
        scene6D.SetActive(true);

        scene6A.SetActive(false);
        scene6B.SetActive(false);
        scene6C.SetActive(false);
        sceneEndKF.SetActive(false);
        noteButtonKF.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelaySceneEndKF()
    {
        yield return new WaitForSeconds(0.9f);
        sceneEndKF.SetActive(true);

        scene6A.SetActive(false);
        scene6B.SetActive(false);
        scene6C.SetActive(false);
        scene6D.SetActive(false);
        noteButtonKF.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }
}
