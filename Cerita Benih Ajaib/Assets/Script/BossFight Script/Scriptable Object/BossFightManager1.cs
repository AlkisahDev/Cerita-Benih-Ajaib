using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BossFightManager1 : MonoBehaviour
{
    public List<BossFightQuestion> BossList = new List<BossFightQuestion>();
    public TMP_Text question, optionA, optionB, optionC, optionD;
    public Image imageQuestion;
    public int roundloss = 0;
    public int indexBoss = 0;
    public int correctAnswer;
    public int wrongAnswer;
    public float timerBoss;
    public float startTime;
    public bool endOfStage = false;
    public bool butoIjoGetClose;
    public bool endOfBossFight = false;
    public bool timeIsUp;
    public GameObject feedbackBenar, feedbackSalah;
    public GameObject winPanel, retryPanel;
    public Image timerUI;

    [SerializeField] GameObject butoIjo;
    [SerializeField] Animator animator;
    [SerializeField] Animator ButoIjoAnimator;
    [SerializeField] GameObject sprite1;
    public GameObject sprite2;

    private void Start()
    {
        endOfBossFight = false;
        animator.SetBool("isThrowing", false);
        butoIjoGetClose = false;
        SetupQuestion();
        timerUI.fillAmount = 1f;
        timerBoss = startTime + 2f;
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
            feedbackBenar.SetActive(false);
            feedbackBenar.SetActive(true);
        }
        else if (isCorrect == false)
        {
            wrongAnswer++;
            feedbackSalah.SetActive(false);
            feedbackSalah.SetActive(true);
        }

        if (indexBoss == 0 || indexBoss == 1)
        {
            indexBoss++;
            SetupQuestion();
        }
        else if (indexBoss == 2)
        {
            endOfStage = true;
            indexBoss++;
            SetupQuestion();
        }
        else if (indexBoss == 3 || indexBoss == 4)
        {
            indexBoss++;
            SetupQuestion();
        }
        else if (indexBoss == 5)
        {
            endOfStage = true;
            indexBoss++;
            SetupQuestion();
        }
        else if (indexBoss == 6 || indexBoss == 7)
        {
            indexBoss++;
            SetupQuestion();
        }
        else if (indexBoss == 8)
        {
            endOfStage = true;
            endOfBossFight = true;
        }
    }

    private void Update()
    {
        BossTimer();
        if (timeIsUp == true)
        {
            RoundLoss();
        }

        if (correctAnswer <= 3 && correctAnswer >= 2 &&
            wrongAnswer <= 1 && wrongAnswer >= 0 &&
            endOfStage == true
            )
        {
            RoundWin();
        }

        else if (correctAnswer >= 0 && correctAnswer <= 1 &&
            wrongAnswer >= 2 && wrongAnswer <= 3
            && endOfStage == true)
        {
            RoundLoss();
        }


        else if (roundloss <= 2 && endOfBossFight == true)
        {
            Debug.Log("MENANG");
            StartCoroutine(ConditionPanelWin());
            ButoIjoAnimator.SetBool("IsDefeat", true);
            animator.SetBool("isVictory", true);
        }

        else if (roundloss >= 3 && endOfBossFight == true)
        {
            Debug.Log("KALAH");
            StartCoroutine(ConditionPanelLose());
        }
    }
    public void BossTimer()
    {
        if (timeIsUp == false)
        {
            timerBoss -= Time.deltaTime;
            if (timerBoss <= 0f)
            {
                timeIsUp = true;
                timerBoss = 0f;
                RoundLoss();
            }

            float timerNormalized = Mathf.Clamp(timerBoss / startTime, 0f, 1f);
            timerUI.fillAmount = timerNormalized;
        }
    }

    public void RoundWin()
    {
        Vector3 butoIjoPosition = butoIjo.transform.position;
        Debug.Log(endOfStage);
        butoIjoGetClose = false;

        animator.SetBool("isThrowing", true);
        sprite1.SetActive(true);

        // posisi sprite 1 = posisi buto ijo
        //sprite1.transform.position = butoIjoPosition;

        //animasi gerak sprite 1
        LeanTween.move(sprite1, new Vector3(0, butoIjoPosition.y, 0), 0.6f);

        sprite2.transform.position = butoIjoPosition;
        LeanTween.scale(sprite2, new Vector3(40, 30, 1), 1f);


        StartCoroutine(TransitionAnimation());

        Debug.Log(endOfStage);
        correctAnswer = 0;
        wrongAnswer = 0;
        timerBoss = startTime + 4f;
        endOfStage = true;
    }

    public void RoundLoss()
    {
        //StopBossTimer();
        endOfStage = true;
        butoIjoGetClose = true;


        if (butoIjoGetClose == true)
        {
            LeanTween.move(butoIjo, new Vector3(0, butoIjo.transform.position.y + 1.103f, 0), 0.5f);
        }

        butoIjoGetClose = false;
        correctAnswer = 0;
        wrongAnswer = 0;
        roundloss++;
        timeIsUp = false;
        timerBoss = startTime;
    }

    IEnumerator TransitionAnimation()
    {
        yield return new WaitForSeconds(2f);
        animator.SetBool("isThrowing", false);
        sprite2.LeanScale(Vector3.zero, 0.5f);
        sprite1.transform.position = new Vector3(0, 2.37f, 0);
    }

    IEnumerator ConditionPanelWin()
    {
        yield return new WaitForSeconds(3f);
        winPanel.SetActive(true);
    }
    IEnumerator ConditionPanelLose()
    {
        yield return new WaitForSeconds(3f);
        retryPanel.SetActive(true);
    }
}
