using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modules : MonoBehaviour
{

    public void LoadModules()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackToMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void LoadPreTest()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadModuleOneQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void LoadModuleTwoQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void LoadModuleThreeQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void LoadModuleFourQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void LoadModuleFiveQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void LoadModuleSixQuiz()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void LoadModuleSevenQuiz()

    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    public void LoadModuleEightQuiz()

    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }

    public void Profile()

    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }

    public void QuitGame()
    {

        Application.Quit();
    }
}
