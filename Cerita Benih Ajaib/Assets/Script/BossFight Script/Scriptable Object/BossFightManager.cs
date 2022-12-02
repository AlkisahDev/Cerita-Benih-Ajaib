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
    public bool butoIjoGetClose;

    [SerializeField] GameObject butoIjo;
    [SerializeField] Animator animator;
    private void Start()
    {
        animator.SetBool("isThrowing", false);
        butoIjoGetClose = false;
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
            correctAnswer++;
            Debug.Log("Benar");
            Debug.Log(correctAnswer);
        }
        else
        {
            Debug.Log(correctAnswer);
            Debug.Log("Salah");
        }

        // pertanyaan ke 1-2
        if (indexBoss != 2)
        {
            indexBoss++;
            SetupQuestion();
        }

        //pertanyaan ke - 3
        else if (indexBoss == 2)
        {
            isAnswered = true;
        }
    }

    public void Update()
    {
        // kalau salah 1 kurang
        if (correctAnswer <= 3 && correctAnswer >= 2 && isAnswered == true)
        {
            butoIjoGetClose = false;

            animator.SetBool("isThrowing", true);
            StartCoroutine(AnimationNormal());
            correctAnswer = 0;
            indexBoss = 0;
            SetupQuestion();
        }
        // kalau salah 2 lebih
        else if (correctAnswer > 0 && correctAnswer < 2 && isAnswered == true)
        {
            butoIjoGetClose = true;
            if (butoIjoGetClose == true)
            {
                LeanTween.move(butoIjo, new Vector3(0, butoIjo.transform.position.y + 1.103f, 0), 0.5f);
            }
            butoIjoGetClose = false;
            correctAnswer = 0;
            isAnswered = false;
            indexBoss = 0;
            SetupQuestion();
        }
    }

    IEnumerator AnimationNormal()
    {
        yield return new WaitForSeconds(2f);
        isAnswered = false;
        animator.SetBool("isThrowing", false);
    }
}
