using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPRefill : MonoBehaviour
{

    // animator field of hpbox
    public Animator anim;

    // player hp from ui
    public Image content;

    // bool to see if it was used or not
    private bool used = false;

    void Start()
    {
        // gets the animator and player HP from ui
        anim = GetComponent<Animator>();
        content = GameObject.Find("content").GetComponent<Image>();
    }

    // if the player collides with the box and the player doesn't have full health it refill the player health to full and changes the box animation to the used animation
    // and changes the bool to used
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && used != true && content.fillAmount != 1.0f)
        {
            content.fillAmount = 1.0f;
            anim.SetBool("Used", true);
            used = true;
        }
    }

}
