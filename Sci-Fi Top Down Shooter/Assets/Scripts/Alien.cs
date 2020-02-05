using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.Animations;

public class Alien : MonoBehaviour
{

    // health amount of alien
    public float healthAmount = 1.0f;
    
    // get set property of health
    public float HealthAmount
    {
        get
        {
            return healthAmount;
        }
        set
        {
            healthAmount = value;
        }
    }

    // constructor for alien class
    public Alien()
    {
        healthAmount = 1.0f;
    }


    // Start is called before the first frame update
    void Start()
    {
        healthAmount = 1f;

    }



    // Update is called once per frame
    void Update()
    {

        // if the health is less than 1% it destroys the alien
        if (healthAmount <= 0.01)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        // if it collides with a bullet that it loses a third of it's health
        if (collision.gameObject.CompareTag("Bullet") )
        {
            healthAmount -= 0.34f;
        }

        // so that the player can go through the enemy sprite
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.rigidbody.isKinematic = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        // returns the player back to the dynamic rigidbody so that the player can't go through other colliders like walls and barrels
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.rigidbody.isKinematic = false;
        }
    }


}
