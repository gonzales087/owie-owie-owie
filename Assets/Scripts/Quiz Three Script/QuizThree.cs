using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizThree : MonoBehaviour
{

    public List<QnAQuizThree> QnAQuizThree;
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

        totalQuestions = QnAQuizThree.Count;
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
        QnAQuizThree.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {

        QnAQuizThree.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void QuizThreeToModuleMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    void SetAnswers()
    {

        for (int i = 0; i < options.Length; i++)
        {

            options[i].GetComponent<AnswerScriptQuizThree>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnAQuizThree[currentQuestion].Answers[i];

            if (QnAQuizThree[currentQuestion].CorrectAnswer == i + 1)
            {

                options[i].GetComponent<AnswerScriptQuizThree>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {

        if (QnAQuizThree.Count > 0)
        {

            currentQuestion = Random.Range(0, QnAQuizThree.Count);

            questionText.text = QnAQuizThree[currentQuestion].Question;
            SetAnswers();
        }

        else
        {

            Debug.Log("End of test");
            GameOver();
        }
    }
}

