using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public bool autoStart = false;
    public Message[] messages;
    public Actor[] actors;

    private void Start()
    {
        if (autoStart == true)
        {
            StartCoroutine(AutoStartDialog());
        }
    }

    private void StartDialogue()
    {
        Debug.Log("Start Dialogue");
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
    }

    IEnumerator AutoStartDialog()
    {
        yield return new WaitForSeconds(1f);
        StartDialogue();
    }
}


[System.Serializable]
public class Message
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}