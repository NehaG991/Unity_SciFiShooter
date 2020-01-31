using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPBar : Alien //MonoBehaviour
{
    Vector3 localScale;
    public Alien alien;
    private float health;
    EnemyHPBar hpBar;
    public GameObject enemy;

    public float Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }


    void Start()
    {
        // THIS WORKS WITHOUT STATIC HEALTH VARIABLE
        alien = enemy.GetComponent<Alien>();
        health = alien.HealthAmount;
        localScale.x = health;
        localScale = transform.localScale;




        //alien.HealthAmount = gameObject.GetComponentInParent<Alien>().healthAmount;

        /*health = gameObject.GetComponentInParent<Alien>().HealthAmount;
        localScale.x = health;
        localScale = transform.localScale;*/

        //localScale.x = Alien.healthAmount;
        //localScale = transform.localScale;    
    }

    void Update()
    {
        



        // THIS WORKS WITHOUT STATIC HEALTH VARIABLE
        health = alien.HealthAmount;
        Debug.Log(health);
        localScale.x = health;
        transform.localScale = localScale;


        //alien.HealthAmount = gameObject.GetComponentInParent<Alien>().healthAmount;

        //health = gameObject.GetComponentInParent<Alien>().HealthAmount;
        //Debug.Log(health);
        //localScale.x = health;
        //localScale = transform.localScale;
        //transform.localScale = localScale;


        //localScale.x = Alien.healthAmount; 
        //transform.localScale = localScale;
    }

}
