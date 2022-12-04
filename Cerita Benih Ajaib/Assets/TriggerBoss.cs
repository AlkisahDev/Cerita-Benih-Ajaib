using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Triggered BOSS FIGHT");
            SceneLoader.ProgressLoad("New BossFight Copy");
        }
    }
}
