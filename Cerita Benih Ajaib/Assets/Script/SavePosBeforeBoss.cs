using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePosBeforeBoss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DataPersistenceManager.instance.SaveGame();
        }
    }
}
