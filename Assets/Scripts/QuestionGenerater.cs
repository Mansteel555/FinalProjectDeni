using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerater : MonoBehaviour
{

    public static string trueAnswer;
    public static bool checkIfQuesitonShows = false;
    public int numberOfQuestions;

  
    void Update()
    {
        if (checkIfQuesitonShows == false)
        {
            checkIfQuesitonShows = true;
            numberOfQuestions = Random.Range(1, 11);

            if (numberOfQuestions == 1)
            {

                
                QuestionShow.newQuestion = "What is the definition of insanity?";
                QuestionShow.newFirst = "Doing the same thing over and over again";
                QuestionShow.newSecound = "The state of being seriously mentally ill";
                QuestionShow.newThird = "Feeling a little bit unwell";
                QuestionShow.newFourth = "Wanting to pay taxes";
                trueAnswer = "B";
            }
            if (numberOfQuestions == 2)
            {

                
                QuestionShow.newQuestion = "Who is Luke Skywalker's father?";
                QuestionShow.newFirst = "Obi Wan Kenobi";
                QuestionShow.newSecound = "Yoda";
                QuestionShow.newThird = "Darth Vader";
                QuestionShow.newFourth = "Han Solo";
                trueAnswer = "C";
            }
            if (numberOfQuestions == 3)
            {

                
                QuestionShow.newQuestion = "What is the meaning of memes?";
                QuestionShow.newFirst = "To make people laugh";
                QuestionShow.newSecound = "They don't have a meaning";
                QuestionShow.newThird = "To spread chaos";
                QuestionShow.newFourth = "To show the definition of insanity";
                trueAnswer = "D";
            }
            if (numberOfQuestions == 4)
            {

                
                QuestionShow.newQuestion = "What is Unity, the company currently doing?";
                QuestionShow.newFirst = "Trying to make money(Poorly)";
                QuestionShow.newSecound = "Making good decisions(Lol)";
                QuestionShow.newThird = "Committing sucide";
                QuestionShow.newFourth = "Speedrunning bankruptcy";
                trueAnswer = "A";
            }
            if (numberOfQuestions == 5)
            {


                QuestionShow.newQuestion = "What were FPS games called before Half Life was released?";
                QuestionShow.newFirst = "Shooters";
                QuestionShow.newSecound = "Doom Clones";
                QuestionShow.newThird = "Nazi Killers";
                QuestionShow.newFourth = "War Games";
                trueAnswer = "B";
            }
            if (numberOfQuestions == 6)
            {


                QuestionShow.newQuestion = "What course is this quiz made for?";
                QuestionShow.newFirst = "Game Design";
                QuestionShow.newSecound = "Unity";
                QuestionShow.newThird = "DataBase";
                QuestionShow.newFourth = "Unreal";
                trueAnswer = "B";
            }
            if (numberOfQuestions == 7)
            {


                QuestionShow.newQuestion = "How much blood does an adult human have in their body?";
                QuestionShow.newFirst = "5 gallons of blood";
                QuestionShow.newSecound = "2 liters of blood";
                QuestionShow.newThird = "1.2 - 1.5 gallons of blood";
                QuestionShow.newFourth = "9 liters of blood";
                trueAnswer = "C";
            }
            if (numberOfQuestions == 8)
            {


                QuestionShow.newQuestion = "How old is the batman franchise?";
                QuestionShow.newFirst = "100 years";
                QuestionShow.newSecound = "56 years";
                QuestionShow.newThird = "83 years";
                QuestionShow.newFourth = "67 years";
                trueAnswer = "C";
            }
            if (numberOfQuestions == 9)
            {


                QuestionShow.newQuestion = "What is the oldest age a human has lived?";
                QuestionShow.newFirst = "122 years";
                QuestionShow.newSecound = "125 years";
                QuestionShow.newThird = "113 years";
                QuestionShow.newFourth = "109 years";
                trueAnswer = "A";
            }
            if (numberOfQuestions == 10)
            {


                QuestionShow.newQuestion = "Which one of these is a quote from Jurassic Park?";
                QuestionShow.newFirst = "It's alive!";
                QuestionShow.newSecound = "There's no place like home";
                QuestionShow.newThird = "I'll be back";
                QuestionShow.newFourth = "Life, uh, finds a way";
                trueAnswer = "D";
            }
            QuestionShow.updateQuestion = false;


        }
    }
}
