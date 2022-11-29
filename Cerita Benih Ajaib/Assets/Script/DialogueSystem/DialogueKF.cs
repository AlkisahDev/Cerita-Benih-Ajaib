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

    private void Start()
    {
        Debug.Log("Now " + currentSceneKF);
        currentSceneKF = KakFloraScene.scene6A;
        activeSceneKF = PlayerPrefs.GetInt("KakFlora", 0);
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
                StartCoroutine(DelayScene6A());
                return;

            case KakFloraScene.scene6B:
                StartCoroutine(DelayScene6B());
                break;

            case KakFloraScene.scene6C:
                StartCoroutine(DelayScene6C());
                PlayerPrefs.SetInt("KakFlora", 3);
                break;

            case KakFloraScene.scene6D:
                StartCoroutine(DelayScene6D());
                PlayerPrefs.SetInt("KakFlora", 4);
                break;

            case KakFloraScene.sceneEndKF:
                StartCoroutine(DelaySceneEndKF());
                break;
        }
    }

    IEnumerator DelayScene6A()
    {
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
        // yield return new WaitForSeconds(1f);
    }
}
