using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Soal")]

public class QuestionNPC : ScriptableObject
{
    public string question;
    // public string imageQuest;

    public string OptionA, OptionB, OptionC, OptionD;
    public int result;
}
