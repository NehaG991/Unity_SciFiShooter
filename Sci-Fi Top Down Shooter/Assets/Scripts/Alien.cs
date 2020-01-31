using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class Alien : MonoBehaviour
{
    public float healthAmount = 1.0f;
    

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
        if (healthAmount <= 0.01)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Bullet") )
        {
            healthAmount -= 0.15f;
        }
    }


}
