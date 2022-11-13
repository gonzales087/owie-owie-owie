using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizFour : MonoBehaviour
{

    public List<QnAQuizFour> QnAQuizFour;
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

        totalQuestions = QnAQuizFour.Count;
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
        QnAQuizFour.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {

        QnAQuizFour.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void QuizFourToModuleMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    void SetAnswers()
    {

        for (int i = 0; i < options.Length; i++)
        {

            options[i].GetComponent<AnswerScriptQuizFour>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnAQuizFour[currentQuestion].Answers[i];

            if (QnAQuizFour[currentQuestion].CorrectAnswer == i + 1)
            {

                options[i].GetComponent<AnswerScriptQuizFour>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {

        if (QnAQuizFour.Count > 0)
        {

            currentQuestion = Random.Range(0, QnAQuizFour.Count);

            questionText.text = QnAQuizFour[currentQuestion].Question;
            SetAnswers();
        }

        else
        {

            Debug.Log("End of test");
            GameOver();
        }
    }
}

