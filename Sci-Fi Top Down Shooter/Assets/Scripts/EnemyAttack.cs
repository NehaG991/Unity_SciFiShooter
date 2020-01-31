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
        anim = GetComponent<Animator>();
        content = GameObject.Find("content").GetComponent<Image>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("attack", true);
            // decreases health by 10% everytime is attacked
            content.fillAmount -= 0.15f;

            // need to make a death animation
            /*if (content.fillAmount <= 0.01f)
            {
                Destroy(collision.gameObject);
                
            }*/
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("attack", false);
        }
    }

    
}
