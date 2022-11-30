using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] Image actorImage;
    [SerializeField] TMP_Text actorName;
    [SerializeField] TMP_Text messageText;
    [SerializeField] RectTransform backgroundBox;

    public GameObject joystick;
    private bool isDialogueActive = false;

    [SerializeField] GameObject dialogButton;
    [SerializeField] GameObject nextDialogButton;
    [SerializeField] GameObject currentScene;
    [SerializeField] private bool isCurrentSceneOneTime;




    public enum NPCType
    {
        PakDali,
        KakFlora,
        KakSandi,
        NPC
    }
    public NPCType currentNPC;

    Message[] currentMessages;
    Actor[] currentActors;

    int activeMessage = 0;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;

        currentScene.SetActive(true);
        Debug.Log("Open Dialogue");
        DisplayMessage();
    }

    private void DisplayMessage()
    {
        isDialogueActive = true;

        dialogButton.SetActive(false);

        messageText.text = "";
        StartCoroutine(Typing());

        Message messageToDisplay = currentMessages[activeMessage];

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

        backgroundBox.LeanScale(Vector3.one, 0.8f).setEaseInOutExpo();
        nextDialogButton.SetActive(true);
    }

    IEnumerator Typing()
    {
        activeMessage++;
        string message = currentMessages[activeMessage].message;

        foreach (char letter in message.ToCharArray())
        {
            messageText.text += letter;
            nextDialogButton.SetActive(false);
            yield return new WaitForSeconds(0.015f);
            nextDialogButton.SetActive(true);
        }
    }


    private void NextMessage()
    {
        if (activeMessage < currentMessages.Length - 1)
        {
            DisplayMessage();
        }
        else
        {
            Debug.Log("End of Dialogue");

            // harus di assign ke dialog character (misal: currentNPC = activeScenePD)
            if (currentNPC == NPCType.PakDali)
            {
                FindObjectOfType<DialoguePD>().activeScenePD++;
            }

            else if (currentNPC == NPCType.KakFlora)
            {
                FindObjectOfType<DialogueKF>().activeSceneKF++;
            }

            else if (currentNPC == NPCType.KakSandi)
            {
                FindObjectOfType<DialogueKS>().activeSceneKS++;
            }

            StartCoroutine(AnimateBoxOut());
            isDialogueActive = false;
            nextDialogButton.SetActive(false);
        }
    }

    IEnumerator AnimateBoxOut()
    {
        backgroundBox.LeanScale(Vector3.zero, 0.8f).setEaseInOutExpo();
        yield return new WaitForSeconds(0.8f);
        if (isCurrentSceneOneTime == true)
        {
            backgroundBox.gameObject.SetActive(false);

            currentScene.SetActive(false);
            dialogButton.SetActive(false);
        }
        else
        {
            dialogButton.SetActive(true);
        }
    }

    void Start()
    {
        isDialogueActive = false;

        currentScene.SetActive(true);
        backgroundBox.transform.localScale = new Vector3(0, 0, 0);
        dialogButton.SetActive(true);
    }

    void Update()
    {
        if (isDialogueActive == true)
        {
            joystick.SetActive(false);
        }
        else
        {
            joystick.SetActive(true);
        }
    }

    public void NextMessageButton()
    {
        NextMessage();
    }
}