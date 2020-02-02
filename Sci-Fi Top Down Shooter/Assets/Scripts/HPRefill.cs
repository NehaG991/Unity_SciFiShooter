using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPRefill : MonoBehaviour
{
    public Animator anim;
    public Image content;
    private bool used = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        content = GameObject.Find("content").GetComponent<Image>();
    }

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
