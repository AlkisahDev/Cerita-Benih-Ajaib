using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    private void StartDialogue()
    {
        Debug.Log("Start Dialogue");
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
    }

    public void StartMiniGame(string sceneName)
    {
        SceneLoader.ProgressLoad(sceneName);
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