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



    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "How many doors does it take to change a bar in the sea?";
        firstAnswer.GetComponent<Text>().text = "Five Doors";
        secoundAnswer.GetComponent<Text>().text = "What?";
        thirdAnswer.GetComponent<Text>().text = "What bar?";
        fourthAnswer.GetComponent<Text>().text = "This isn't a even a question!";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
