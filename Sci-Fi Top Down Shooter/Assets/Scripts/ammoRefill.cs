using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoRefill : MonoBehaviour
{

    public Animator anim;

    // UI text stuff
    public Text clipText;

    private string cstring;
    private int clips;
    private int indexSpace;
    private string clipsString;

    private bool used = false;

    void Start()
    {
        anim = GetComponent<Animator>();

        clipText = GameObject.Find("BulletLeftText").GetComponent<Text>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && used != true)
        {
            anim.SetBool("Used", true);

            cstring = clipText.text;

            clips = int.Parse(cstring);

            clips += 30;

            clipText.text = clips.ToString();

            used = true;
        }
    }
}
