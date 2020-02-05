using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAttack : MonoBehaviour
{

    public Animator anim;
    public Image content;


    void Start()
    {
        // gets the animator component of the enemy and the player hp
        anim = GetComponent<Animator>();
        content = GameObject.Find("content").GetComponent<Image>();
    }

    // if the player triggers the enemy that it plays the attack animation and lowers player health
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("attack", true);

            // decreases health everytime is attacked
            content.fillAmount -= 0.015f;

        }

    }

    /*public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("attack", false);
        }
    }*/

    
}
