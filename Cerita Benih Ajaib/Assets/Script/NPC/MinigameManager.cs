using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour
{
    public List<QuestionNPC> questionList = new List<QuestionNPC>();
    public TMP_Text question, OptionA, OptionB, OptionC, OptionD, indikator;
    public Image imageQuest;
    public GameObject feedbackBenar, feedbackSalah;
    public GameObject winPanel, retryPanel;
    private int indexQuestion;
    private int trueResult = 0;
    private bool endQuestion = false;


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

        indikator.text = questionList[indexQuestion].indikator;

        if(questionList[indexQuestion].imageQuest != null)
        {
            imageQuest.gameObject.SetActive(true);
            imageQuest.sprite = questionList[indexQuestion].imageQuest;
        }
        else
        {
            imageQuest.gameObject.SetActive(false);
        }        
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
        if (resultTrue)
        {
            Debug.Log("Benar");
            feedbackBenar.SetActive(false);
            feedbackBenar.SetActive(true);

            trueResult++;
        }
        else
        {
            Debug.Log("Salah");
            feedbackSalah.SetActive(false);
            feedbackSalah.SetActive(true);
        }


        if (indexQuestion != 2)
        {
            indexQuestion++;
            SetupQuestion();
        }
        else if (indexQuestion == 2)
        {
            endQuestion = true;
        }
    }

    public void Update()
    {
        StartCoroutine(ConditionPanel());
        
        //delay
        IEnumerator ConditionPanel()
        {
            if (trueResult >= 2 && endQuestion == true)
        {
            yield return new WaitForSeconds(1);
            winPanel.SetActive(true);
        }
        if (trueResult <= 1 && endQuestion == true)
        {
            yield return new WaitForSeconds(1);
            retryPanel.SetActive(true);

        }
    }
}

    public void RetryKakFlora()
    {
        SceneManager.LoadScene("KakFlora");
    }
    public void RetryKakSandi()
    {
        SceneManager.LoadScene("KakSandi");
    }
    public void RetryPakDali()
    {
        SceneManager.LoadScene("PakDali");
    }
}