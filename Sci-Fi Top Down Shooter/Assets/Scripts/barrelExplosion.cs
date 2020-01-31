using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barrelExplosion : Alien
{

    private bool exploding;
    private bool done;
    public Animator anim;
    public Image content;
    private Alien alien;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        content = GameObject.Find("content").GetComponent<Image>();
        this.exploding = false;
        this.done = false;

    }

    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("barrelExplosion"))
        {
            this.exploding = true;
        } 
        else if (anim.GetCurrentAnimatorStateInfo(0).IsName("barrel - final"))
        {
            enabled = false;
            this.exploding = false;
        }
        else
        {
            this.exploding = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (exploding == false && done == false)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                exploding = true;
                anim.SetBool("exploding", true);

            }
        }


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.exploding)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                content.fillAmount -= 0.25f;
            }

            if (collision.gameObject.CompareTag("Enemy"))
            {
                alien = collision.GetComponent<Alien>();
                alien.HealthAmount -= 0.5f;
                Debug.Log(alien.HealthAmount);
            }
        }


    }


}
