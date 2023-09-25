using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnswer : MonoBehaviour
{
    public GameObject firstAnswerWait;
    public GameObject firstAnswerCorrect;
    public GameObject firstAnswerWrong;

    public GameObject secoundAnswerWait;
    public GameObject secoundAnswerCorrect;
    public GameObject secoundAnswerWrong;

    public GameObject thirdAnswerWait;
    public GameObject thirdAnswerCorrect;
    public GameObject thirdAnswerWrong;


    public GameObject fourthAnswerWait;
    public GameObject fourthAnswerCorrect;
    public GameObject fourthAnswerWrong;

    public GameObject firstAnswer;
    public GameObject secoundAnswer;
    public GameObject thirdAnswer;
    public GameObject fourthAnswer;

    public AudioSource correctSound;
    public AudioSource wrongSound;

    public GameObject currentScore;
    public int scoreValue;
    public int highScore;
    public GameObject highDisplay;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScoreQuiz");
        highDisplay.GetComponent<Text>().text = "HIGHEST: " + highScore;
    }


    void Update()
    {
        currentScore.GetComponent<Text>().text = "SCORE: " + scoreValue;  

    }

    public void FirstAnswer()
    {

        if (QuestionGenerater.trueAnswer == "A")
        {
            firstAnswerCorrect.SetActive(true);
            firstAnswerWait.SetActive(false);
            correctSound.Play();
            scoreValue += 5;
            StartCoroutine(MoveToNextQuestion());
        }
        else
        {
            firstAnswerWrong.SetActive(true);
            firstAnswerWait.SetActive(false);
            wrongSound.Play();
            scoreValue -= 5;
        }
        firstAnswer.GetComponent<Button>().enabled = false;
        secoundAnswer.GetComponent<Button>().enabled = false;
        thirdAnswer.GetComponent<Button>().enabled = false;
        fourthAnswer.GetComponent<Button>().enabled = false;
        StartCoroutine(MoveToNextQuestion());
    }

    public void SecoundAnswer()
    {
        if (QuestionGenerater.trueAnswer == "B")
        {
            secoundAnswerCorrect.SetActive(true);
            secoundAnswerWait.SetActive(false);
            correctSound.Play();
            scoreValue += 5;
        }
        else
        {
            secoundAnswerWrong.SetActive(true);
            secoundAnswerWait.SetActive(false);
            wrongSound.Play();
            scoreValue -= 5;
        }
        firstAnswer.GetComponent<Button>().enabled = false;
        secoundAnswer.GetComponent<Button>().enabled = false;
        thirdAnswer.GetComponent<Button>().enabled = false;
        fourthAnswer.GetComponent<Button>().enabled = false;
        StartCoroutine(MoveToNextQuestion());
    }

    public void ThirdAnswer()
    {
        if (QuestionGenerater.trueAnswer == "C")
        {
            thirdAnswerCorrect.SetActive(true);
            thirdAnswerWait.SetActive(false);
            correctSound.Play();
            scoreValue += 5;
        }
        else
        {
            thirdAnswerWrong.SetActive(true);
            thirdAnswerWait.SetActive(false);
            wrongSound.Play();
            scoreValue -= 5;
        }
        firstAnswer.GetComponent<Button>().enabled = false;
        secoundAnswer.GetComponent<Button>().enabled = false;
        thirdAnswer.GetComponent<Button>().enabled = false;
        fourthAnswer.GetComponent<Button>().enabled = false;
        StartCoroutine(MoveToNextQuestion());
    }

    public void FourthAnswer()
    {
        if (QuestionGenerater.trueAnswer == "D")
        {
            fourthAnswerCorrect.SetActive(true);
            fourthAnswerWait.SetActive(false);
            correctSound.Play();
            scoreValue += 5;
        }
        else
        {
            fourthAnswerWrong.SetActive(true);
            fourthAnswerWait.SetActive(false);
            wrongSound.Play();
            scoreValue -= 5;
        }
        firstAnswer.GetComponent<Button>().enabled = false;
        secoundAnswer.GetComponent<Button>().enabled = false;
        thirdAnswer.GetComponent<Button>().enabled = false;
        fourthAnswer.GetComponent<Button>().enabled = false;
        StartCoroutine(MoveToNextQuestion());
    }

    IEnumerator MoveToNextQuestion()
    {
        if (highScore < scoreValue)
        {
            PlayerPrefs.SetInt("HighScoreQuiz", scoreValue);
            highScore = scoreValue;
            highDisplay.GetComponent<Text>().text = "HIGHEST: " + scoreValue;
        }
        yield return new WaitForSeconds(2);

        firstAnswerCorrect.SetActive(false);
        secoundAnswerCorrect.SetActive(false);
        thirdAnswerCorrect.SetActive(false);
        fourthAnswerCorrect.SetActive(false);

        firstAnswerWrong.SetActive(false);
        secoundAnswerWrong.SetActive(false);
        thirdAnswerWrong.SetActive(false);
        fourthAnswerWrong.SetActive(false);

        firstAnswerWait.SetActive(true);
        secoundAnswerWait.SetActive(true);
        thirdAnswerWait.SetActive(true);
        fourthAnswerWait.SetActive(true);

        firstAnswer.GetComponent<Button>().enabled = true;
        secoundAnswer.GetComponent<Button>().enabled = true;
        thirdAnswer.GetComponent<Button>().enabled = true;
        fourthAnswer.GetComponent<Button>().enabled = true;

        QuestionGenerater.checkIfQuesitonShows = false;
    }
}
