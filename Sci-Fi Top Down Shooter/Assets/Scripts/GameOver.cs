using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public Image playerHP;
    public Text result;
    public GameObject gameOverMenu;
    public Text currTime;

    private float seconds;
    private float minutes;


    // Start is called before the first frame update
    void Start()
    {
        playerHP = GameObject.Find("content").GetComponent<Image>();
        currTime = GameObject.Find("Timer").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
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

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
