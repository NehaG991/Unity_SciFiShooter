using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //fields 
    public Text counterText;
    public float seconds;
    public float minutes;
    public Image playerHP;

    // Start is called before the first frame update
    void Start()
    {
        // gets the timer and player hp from the ui
        counterText = GameObject.Find("Timer").GetComponent<Text>();
        playerHP = GameObject.Find("content").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        // as long as the player is alive, the timer counts up based on how long the game been loaded
        if (playerHP.fillAmount >= 0.1f)
        {
            minutes = (int)(Time.timeSinceLevelLoad / 60f);
            seconds = (int)(Time.timeSinceLevelLoad % 60f);
            counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }


        
    }
}
