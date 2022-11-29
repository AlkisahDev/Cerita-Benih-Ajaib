using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialoguePD : MonoBehaviour
{
    // semua scene
    [SerializeField] GameObject scene5A;
    [SerializeField] GameObject scene5B;
    [SerializeField] GameObject scene5C;
    [SerializeField] GameObject scene5D;
    [SerializeField] GameObject sceneEndPD;

    public int activeScenePD = 0;

    public enum PakDaliScene
    {
        scene5A, // pertama bertemu pak dali
        scene5B, // bertemu setelah membaca catatan
        scene5C, // ganti scene mini game
        scene5D,  // berpisah dengan pak dali
        sceneEndPD, // dialog setelah quest selesai
    }
    public PakDaliScene currentScenePD;

    private void Start()
    {
        Debug.Log("Now " + currentScenePD);
        currentScenePD = PakDaliScene.scene5A;
        activeScenePD = PlayerPrefs.GetInt("PakDali", 0);
    }


    private void Update()
    {
        if (activeScenePD == 0)
        {
            currentScenePD = PakDaliScene.scene5A;
        }
        else if (activeScenePD == 1)
        {
            currentScenePD = PakDaliScene.scene5B;
        }
        else if (activeScenePD == 2)
        {
            currentScenePD = PakDaliScene.scene5C;
        }
        else if (activeScenePD == 3)
        {
            currentScenePD = PakDaliScene.scene5D;
        }
        else if (activeScenePD == 4)
        {
            currentScenePD = PakDaliScene.sceneEndPD;
        }

        switch (currentScenePD)
        {
            case PakDaliScene.scene5A:
                StartCoroutine(DelayScene5A());
                return;

            case PakDaliScene.scene5B:
                StartCoroutine(DelayScene5B());
                break;

            case PakDaliScene.scene5C:
                StartCoroutine(DelayScene5C());
                PlayerPrefs.SetInt("PakDali", 3);
                break;

            case PakDaliScene.scene5D:
                StartCoroutine(DelayScene5D());
                PlayerPrefs.SetInt("PakDali", 4);
                break;

            case PakDaliScene.sceneEndPD:
                StartCoroutine(DelaySceneEndPD());
                break;
        }
    }

    IEnumerator DelayScene5A()
    {
        yield return new WaitForSeconds(0.9f);
        Debug.Log("Now " + currentScenePD);
        scene5A.SetActive(true);

        scene5B.SetActive(false);
        scene5C.SetActive(false);
        scene5D.SetActive(false);
        sceneEndPD.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene5B()
    {
        yield return new WaitForSeconds(0.9f);
        Debug.Log("Now " + currentScenePD);
        scene5B.SetActive(true);

        scene5A.SetActive(false);
        scene5C.SetActive(false);
        scene5D.SetActive(false);
        sceneEndPD.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene5C()
    {
        yield return new WaitForSeconds(0.9f);
        scene5C.SetActive(true);

        scene5A.SetActive(false);
        scene5B.SetActive(false);
        scene5D.SetActive(false);
        sceneEndPD.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelayScene5D()
    {
        yield return new WaitForSeconds(0.9f);
        scene5D.SetActive(true);

        scene5A.SetActive(false);
        scene5B.SetActive(false);
        scene5C.SetActive(false);
        sceneEndPD.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }

    IEnumerator DelaySceneEndPD()
    {
        yield return new WaitForSeconds(0.9f);
        sceneEndPD.SetActive(true);

        scene5A.SetActive(false);
        scene5B.SetActive(false);
        scene5C.SetActive(false);
        scene5D.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }
}
