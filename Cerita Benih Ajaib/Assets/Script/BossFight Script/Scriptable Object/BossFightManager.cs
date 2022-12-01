using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BossFightManager : MonoBehaviour
{
    public List<BossFightQuestion> BossList = new List<BossFightQuestion>();
    public TMP_Text question, optionA, optionB, optionC, optionD;
    public Image imageQuestion;
    private int indexBoss;
    private int correctAnswer = 0;
    public bool isAnswered = false;

    [SerializeField] private GameObject popUp;
    private void Start()
    {
        SetupQuestion();
        indexBoss = 0;
    }

    void SetupQuestion()
    {
        question.text = BossList[indexBoss].question;
        optionA.text = BossList[indexBoss].optionA;
        optionB.text = BossList[indexBoss].optionB;
        optionC.text = BossList[indexBoss].optionC;
        optionD.text = BossList[indexBoss].optionD;

        if (BossList[indexBoss].imageQuestion != null)
        {
            imageQuestion.gameObject.SetActive(true);
            imageQuestion.sprite = BossList[indexBoss].imageQuestion;
        }
        else
        {
            imageQuestion.gameObject.SetActive(false);
        }
    }

    public void ButtonBoss(int b)
    {
        if (b == BossList[indexBoss].answer)
        {
            questionAnswer(true);
        }
        else
        {
            questionAnswer(false);
        }
    }

    void questionAnswer(bool isCorrect)
    {
        if (isCorrect)
        {
            Debug.Log("Benar");
            // Masukin Animasi Meninggal
        }
        else
        {
            Debug.Log("Salah");
            // Dideketin Buto Ijo
        }

        // Tau mana yang bener
        if (indexBoss != 2)
        {
            indexBoss++;
            SetupQuestion();
        }
        else if (indexBoss == 2)
        {
            isAnswered = true;
        }
    }

    public void Update()
    {
        // if (correctAnswer >= 2 && isAnswered == true)
        // {

        // }
    }
}
