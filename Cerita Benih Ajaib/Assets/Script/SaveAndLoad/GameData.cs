using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public Vector3 playerPosition;
    public Vector3 mainCam;
    public Vector3 miniCam;
    public int stateKF;
    public int stateKS;
    public int statePD;

    // public SerializableDictionary<string, bool> coinsCollected;

    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        playerPosition = Vector3.zero;
        mainCam = new Vector3(0, 0, -10);
        miniCam = new Vector3(0, 0, -1);
        stateKF = 0;
        stateKS = 0;
        statePD = 0;
    }
}