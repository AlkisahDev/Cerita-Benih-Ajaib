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
    [SerializeField] Player player;

    // public GameObject noteButtonPD;
    public GameObject itemPD;
    public GameObject gate1;
    public GameObject kochengQPD;
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

    // public void LoadData(GameData data)
    // {
    //     activeScenePD = data.statePD;
    // }

    // public void SaveData(GameData data)
    // {
    //     data.statePD = activeScenePD;
    //     // data.playerPosition = this.transform.position;
    //     // data.mainCam = this.transform.position;
    //     // data.miniCam = this.transform.position;
    // }

    private void Awake()
    {
        // Debug.Log("Now " + currentScenePD);
        currentScenePD = PakDaliScene.scene5A;
        kochengQPD.SetActive(false);
    }

    private void Start()
    {
        activeScenePD = player.ActivePD;
    }

    private void Update()
    {
        if (activeScenePD == 0)
        {
            currentScenePD = PakDaliScene.scene5A;
            // player.ActivePD = 0;
        }
        else if (activeScenePD == 1)
        {
            currentScenePD = PakDaliScene.scene5B;
            // player.ActivePD = 1;
        }
        else if (activeScenePD == 2)
        {
            currentScenePD = PakDaliScene.scene5C;
            // player.ActivePD = 2;
        }
        else if (activeScenePD == 3)
        {
            currentScenePD = PakDaliScene.scene5D;
            // player.ActivePD = 3;
        }
        else if (activeScenePD == 4)
        {
            currentScenePD = PakDaliScene.sceneEndPD;
            player.ActivePD = 4;
        }

        switch (currentScenePD)
        {
            case PakDaliScene.scene5A:

                itemPD.SetActive(false);
                kochengQPD.SetActive(false);
                gate1.SetActive(true);

                StartCoroutine(DelayScene5A());
                return;

            case PakDaliScene.scene5B:

                itemPD.SetActive(false);
                kochengQPD.SetActive(false);
                gate1.SetActive(true);

                StartCoroutine(DelayScene5B());
                break;

            case PakDaliScene.scene5C:
                //Mini Game
                itemPD.SetActive(false);
                kochengQPD.SetActive(false);
                gate1.SetActive(true);

                StartCoroutine(DelayScene5C());
                // activeScenePD = 3;
                player.ActivePD = 3;
                DataPersistenceManager.instance.SaveGame();
                SceneLoader.ProgressLoad("PakDali");
                break;

            case PakDaliScene.scene5D:

                itemPD.SetActive(false);
                kochengQPD.SetActive(false);
                gate1.SetActive(true);

                // Debug.Log(player.ActivePD);
                StartCoroutine(DelayScene5D());
                break;

            case PakDaliScene.sceneEndPD:

                itemPD.SetActive(true);
                kochengQPD.SetActive(true);
                gate1.SetActive(false);

                StartCoroutine(DelaySceneEndPD());
                // player.ActivePD = 4;
                // activeScenePD = 4;
                // DataPersistenceManager.instance.SaveGame();
                break;
        }
    }

    IEnumerator DelayScene5A()
    {
        // noteButtonPD.SetActive(false);
        yield return new WaitForSeconds(0.9f);
        // Debug.Log("Now " + currentScenePD);
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
        // Debug.Log("Now " + currentScenePD);
        scene5B.SetActive(true);

        scene5A.SetActive(false);
        scene5C.SetActive(false);
        scene5D.SetActive(false);
        sceneEndPD.SetActive(false);
        // noteButtonPD.SetActive(true);
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
        // noteButtonPD.SetActive(true);
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
        // noteButtonPD.SetActive(false);
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
        // noteButtonPD.SetActive(false);
        // yield return new WaitForSeconds(1f);
    }
}
