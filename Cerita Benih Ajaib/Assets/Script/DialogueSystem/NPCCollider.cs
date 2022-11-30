using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCCollider : MonoBehaviour
{
    [SerializeField] GameObject interactButton;
    [SerializeField] GameObject dialogCharacter;

    private void Start()
    {
        interactButton.SetActive(false);
        dialogCharacter.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // interactButtonActive = true;
            interactButton.SetActive(true);
            dialogCharacter.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // interactButtonActive = false;
            interactButton.SetActive(false);
            dialogCharacter.SetActive(false);
        }
    }
}
