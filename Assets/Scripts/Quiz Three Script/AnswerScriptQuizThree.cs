using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScriptQuizThree : MonoBehaviour
{

    public bool isCorrect = false;
    public QuizThree testManager;

    public void Answer()
    {

        if (isCorrect)
        {

            Debug.Log("Correct!");
            testManager.correct();
        }

        else
        {

            Debug.Log("Wrong!");
            testManager.wrong();
        }
    }
}