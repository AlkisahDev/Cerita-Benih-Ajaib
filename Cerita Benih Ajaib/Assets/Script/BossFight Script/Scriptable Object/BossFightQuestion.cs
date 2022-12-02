using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Soal Bossfight")]

public class BossFightQuestion : ScriptableObject
{
    public string question;
    public Sprite imageQuestion;
    public string optionA, optionB, optionC, optionD;
    public int answer;    
}
