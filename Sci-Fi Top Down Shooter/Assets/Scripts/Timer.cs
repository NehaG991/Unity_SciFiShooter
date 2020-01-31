using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text counterText;
    public float seconds;
    public float minutes;
    public Image playerHP;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GameObject.Find("Timer").GetComponent<Text>();
        playerHP = GameObject.Find("content").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playerHP.fillAmount >= 0.1f)
        {
            minutes = (int)(Time.time / 60f);
            seconds = (int)(Time.time % 60f);
            counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }


        
    }
}
