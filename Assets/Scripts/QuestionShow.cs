using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionShow : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject firstAnswer;
    public GameObject secoundAnswer;
    public GameObject thirdAnswer;
    public GameObject fourthAnswer;
    public static string newQuestion;
    public static string newFirst;
    public static string newSecound;
    public static string newThird;
    public static string newFourth;
    public static bool updateQuestion = false;


    

    // Update is called once per frame
    void Update()
    {
        if (updateQuestion == false) 
        {
            updateQuestion = true;
            StartCoroutine(ForceTextToWork());
        }
    }

    IEnumerator ForceTextToWork()
    {
        yield return new WaitForSeconds(0.10f);
        screenQuestion.GetComponent<Text>().text = newQuestion;
        firstAnswer.GetComponent<Text>().text = newFirst;
        secoundAnswer.GetComponent<Text>().text = newSecound;
        thirdAnswer.GetComponent<Text>().text = newThird;
        fourthAnswer.GetComponent<Text>().text = newFourth;
    }


}
