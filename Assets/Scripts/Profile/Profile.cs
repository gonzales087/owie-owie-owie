using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Profile : MonoBehaviour
{
    public void ProfileBackButton()

    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }
}
