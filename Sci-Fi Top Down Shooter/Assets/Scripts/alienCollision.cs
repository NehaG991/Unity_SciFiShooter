using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alienCollision : MonoBehaviour
{
    public Image playerHP;

    private void Start()
    {
        playerHP = GameObject.Find("content").GetComponent<Image>();
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.rigidbody.isKinematic = true;
            //collision.rigidbody.angularVelocity = 0;
        }    
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.rigidbody.isKinematic = false;
        }
    }

}
