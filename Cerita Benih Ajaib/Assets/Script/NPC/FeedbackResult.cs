using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackResult : MonoBehaviour
{
    public GameObject feedbackBenar, feedbackSalah;

    void Start() {
        
    }
    public void questionResult(bool resultTrue)
    {
        if(resultTrue)
        {
            feedbackBenar.SetActive(false);
            feedbackBenar.SetActive(true);
            //int score = PlayerPrefs.GetInt ("score")+10;
            //PlayerPrefs.SetInt("score", score);
        }
        else
        {
            feedbackSalah.SetActive(false);
            feedbackSalah.SetActive(true);
        }

        // indexQuestion++;
        // SetupQuestion();
    }
}
