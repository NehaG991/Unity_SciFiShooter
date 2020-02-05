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
        // gets the healthamount variable from the alien class so that the healthbar scale can be edited
        alien = enemy.GetComponent<Alien>();
        health = alien.HealthAmount;
        localScale.x = health;
        localScale = transform.localScale;
    }

    void Update()
    {
        // THIS WORKS WITHOUT STATIC HEALTH VARIABLE
        // transforms the scale of the health based on the currenthealth of the alien object
        health = alien.HealthAmount;
        Debug.Log(health);
        localScale.x = health;
        transform.localScale = localScale;

    }

}
