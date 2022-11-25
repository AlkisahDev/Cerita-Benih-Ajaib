using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCCollider : MonoBehaviour
{
    [SerializeField] GameObject dialoguePanel;
    private bool interactButtonActive;
    [SerializeField] Button interactButton;
    

    private void Start()
    {
        interactButton.interactable = false;
        dialoguePanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (interactButtonActive)
        {
            interactButton.interactable = true;
        }
        else
        {
            interactButton.interactable = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactButtonActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactButtonActive = false;
            interactButton.interactable = false;
            dialoguePanel.SetActive(false);
        }
    }
}
