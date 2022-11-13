using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizTwo : MonoBehaviour
{

    public List<QnAQuizTwo> QnAQuizTwo;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject quizPanel;
    public GameObject scorePanel;

    public TextMeshProUGUI questionText;
    public TextMeshProUGUI scoreText;

    public int questionCounter = 0;
    int totalQuestions = 0;
    public int score;

    private void Start()
    {

        totalQuestions = QnAQuizTwo.Count;
        scorePanel.SetActive(false);
        generateQuestion();
    }

    void GameOver()
    {

        quizPanel.SetActive(false);
        scorePanel.SetActive(true);
        scoreText.text = score + "/" + totalQuestions;
    }

    public void correct()
    {

        score += 1;
        QnAQuizTwo.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {

        QnAQuizTwo.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void QuizTwoToModuleMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    void SetAnswers()
    {

        for (int i = 0; i < options.Length; i++)
        {

            options[i].GetComponent<AnswerScriptQuizTwo>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnAQuizTwo[currentQuestion].Answers[i];

            if (QnAQuizTwo[currentQuestion].CorrectAnswer == i + 1)
            {

                options[i].GetComponent<AnswerScriptQuizTwo>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {

        if (QnAQuizTwo.Count > 0)
        {

            currentQuestion = Random.Range(0, QnAQuizTwo.Count);

            questionText.text = QnAQuizTwo[currentQuestion].Question;
            SetAnswers();
        }

        else
        {

            Debug.Log("End of test");
            GameOver();
        }
    }
}

