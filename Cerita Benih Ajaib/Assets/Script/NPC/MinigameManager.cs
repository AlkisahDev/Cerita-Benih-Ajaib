using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MinigameManager : MonoBehaviour
{
    public List<QuestionNPC> questionList = new List<QuestionNPC>();
    public TMP_Text question, OptionA, OptionB, OptionC, OptionD;
    // public Image imageQuest;

    private int indexQuestion;
    
    private void Start() 
    {
        SetupQuestion();
        indexQuestion = 0;
    }

    void SetupQuestion()
    {
        question.text = questionList[indexQuestion].question;

        OptionA.text = questionList[indexQuestion].OptionA;
        OptionB.text = questionList[indexQuestion].OptionB;
        OptionC.text = questionList[indexQuestion].OptionC;
        OptionD.text = questionList[indexQuestion].OptionD;

        // if(questionList[indexQuestion].imageQuest != null)
        // {
        //     imageQuest.gameObject.SetActive(true);
        //     imageQuest.sprite = questionList[indexQuestion].imageQuest;
        // }
        // else
        // {
        //     imageQuest.gameObject.SetActive(false);
        // }
    }

    public void ButtonQuestion(int n)
    {
        if(n == questionList[indexQuestion].result)
        {
            questionResult(true);
        }
        else
        {
            questionResult(false);
        }
    }

    void questionResult(bool resultTrue)
    {
        if(resultTrue)
        {
            Debug.Log("Benar");
        }
        else
        {
            Debug.Log("Salah");
        }

        indexQuestion++;
        SetupQuestion();
    }
}
