using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDataPersistence
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject miniCam;
    public int ActivePD { get; set; }
    public int ActiveKF { get; set; }
    public int ActiveKS { get; set; }
    // public int ActivePD { get => activePD; set => activePD = value; }
    // int activePD;

    float timer = 0f;

    void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 20f)
        {
            DataPersistenceManager.instance.SaveGame();
            Debug.Log("Save success after 20s");
            timer = 0f;
        }
    }

    public void LoadData(GameData data)
    {
        player.transform.position = data.playerPosition;
        mainCam.transform.position = data.mainCam;
        miniCam.transform.position = data.miniCam;
        ActivePD = data.statePD;
        ActiveKF = data.stateKF;
        ActiveKS = data.stateKS;
    }

    public void SaveData(GameData data)
    {
        data.playerPosition = player.transform.position;
        data.mainCam = mainCam.transform.position;
        data.miniCam = miniCam.transform.position;
        data.statePD = ActivePD;
        data.stateKF = ActiveKF;
        data.stateKS = ActiveKS;
    }
}
