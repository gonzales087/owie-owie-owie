using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizFive : MonoBehaviour
{

    public List<QnAQuizFive> QnAQuizFive;
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

        totalQuestions = QnAQuizFive.Count;
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
        QnAQuizFive.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {

        QnAQuizFive.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void QuizFiveToModuleMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    void SetAnswers()
    {

        for (int i = 0; i < options.Length; i++)
        {

            options[i].GetComponent<AnswerScriptQuizFive>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnAQuizFive[currentQuestion].Answers[i];

            if (QnAQuizFive[currentQuestion].CorrectAnswer == i + 1)
            {

                options[i].GetComponent<AnswerScriptQuizFive>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {

        if (QnAQuizFive.Count > 0)
        {

            currentQuestion = Random.Range(0, QnAQuizFive.Count);

            questionText.text = QnAQuizFive[currentQuestion].Question;
            SetAnswers();
        }

        else
        {

            Debug.Log("End of test");
            GameOver();
        }
    }
}

