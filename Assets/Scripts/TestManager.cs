using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TestManager : MonoBehaviour
{

    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject TestPanel;
    public GameObject ScorePanel;

    public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI questionNumber;

    public int questionCounter = 0;
    int totalQuestions = 0;
    public int score;

    private void Start()
    {

        totalQuestions = QnA.Count;
        ScorePanel.SetActive(false);
        generateQuestion();
    }

    void GameOver()
    {

        TestPanel.SetActive(false);
        ScorePanel.SetActive(true);
        ScoreText.text = score + "/" + totalQuestions;
    }

    public void correct()
    {

        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {

        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void PreTestToMainMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    /*public void PostTestToMainMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }*/

    void SetAnswers()
    {

        for (int i = 0; i < options.Length; i++)
        {

            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {

                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {

        if (QnA.Count > 0)
        {

            currentQuestion = Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswers();
            questionNumber.text = "QUESTION " + questionCounter;
            questionCounter += 1;
        }

        else
        {

            Debug.Log("End of test");
            GameOver();
        }
    }
}
