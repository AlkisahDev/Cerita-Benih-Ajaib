using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataLoadingProgress : MonoBehaviour
{

    void Start()
    {
        DataPersistenceManager.instance.LoadGame();
    }
}
