using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // UI - health bar
    public Image playerHP;

    // UI text for the result 
    public Text result;

    // the gameover menu object
    public GameObject gameOverMenu;

    // the current time
    public Text currTime;

    //varables for the time 
    private float seconds;
    private float minutes;


    // Start is called before the first frame update
    void Start()
    {
        // gets the player hp bar and the time from the UI
        playerHP = GameObject.Find("content").GetComponent<Image>();
        currTime = GameObject.Find("Timer").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // if the player health is less than 0 it stops the game and opens the game over menu
        // game ober menu than states how long you lasted 
        if (playerHP.fillAmount <= 0.01f)
        {
            gameOverMenu.SetActive(true);
            result = GameObject.Find("Time Result").GetComponent<Text>();
            Time.timeScale = 0f;
            minutes = (int)(Time.timeSinceLevelLoad / 60f);
            seconds = (int)(Time.timeSinceLevelLoad % 60f);
            result.text = "You survived for " + minutes.ToString("00") + ":" + seconds.ToString("00");

        }
    }

    // if you click the restart button it restarts the game
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    // if you click the main menu button it open the main menu scene
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
