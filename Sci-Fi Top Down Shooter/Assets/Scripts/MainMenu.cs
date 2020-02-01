using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // play button click function
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    // Quit Button Click Function
    public void QuitGame()
    {
        Application.Quit();
    }
}
