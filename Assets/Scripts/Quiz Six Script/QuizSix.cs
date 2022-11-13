using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizSix : MonoBehaviour
{

    public List<QnAQuizSix> QnAQuizSix;
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

        totalQuestions = QnAQuizSix.Count;
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
        QnAQuizSix.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {

        QnAQuizSix.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void QuizSixToModuleMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }

    void SetAnswers()
    {

        for (int i = 0; i < options.Length; i++)
        {

            options[i].GetComponent<AnswerScriptQuizSix>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnAQuizSix[currentQuestion].Answers[i];

            if (QnAQuizSix[currentQuestion].CorrectAnswer == i + 1)
            {

                options[i].GetComponent<AnswerScriptQuizSix>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {

        if (QnAQuizSix.Count > 0)
        {

            currentQuestion = Random.Range(0, QnAQuizSix.Count);

            questionText.text = QnAQuizSix[currentQuestion].Question;
            SetAnswers();
        }

        else
        {

            Debug.Log("End of test");
            GameOver();
        }
    }
}

