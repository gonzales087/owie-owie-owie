using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScriptQuizTwo : MonoBehaviour
{

    public bool isCorrect = false;
    public QuizTwo testManager;

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