using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Text counterText;
    


    void Start()
    {
        // gets the timer UI component
        counterText = GameObject.Find("Timer").GetComponent<Text>();
    }

    void Update()
    {

        // if the escape key is pressed, then the game opens the pause button or resumes the game based on the current state
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }           
    }

    // resumes the game if the resume button is clicked and resumes the time
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        
        GameIsPaused = false;
    }

    //opens the pause menu and stops the time
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // opens the main menu if the quit button is clicked and starts the time again
    public void Quit()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        counterText.text = "00:00";
        SceneManager.LoadScene("MainMenu");
        
    }

}
