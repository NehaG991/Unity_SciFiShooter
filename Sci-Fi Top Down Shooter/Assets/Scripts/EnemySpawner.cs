using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject parent;
    Vector3 whereToSpawn;
    public float spawnRate = 5f;
    float nextSpawn = 0.0f;
    float health;


    // Update is called once per frame
    void Update()
    {
        // spawns a new enemy if the current time is greater than the spawntime 
        if (Time.time > nextSpawn)
        {
            // updates the nextspawn time 
            nextSpawn = Time.time + spawnRate;

            // creates the enemy object at the spawn location
            whereToSpawn = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            GameObject newEnemy = Instantiate(enemy, whereToSpawn, Quaternion.identity);
            // puts the enemy object underneath the GameHandler object in the hierarchy
            newEnemy.transform.parent = parent.transform;

            // sets the enemy health to 1
            if (newEnemy.CompareTag("Enemy"))
            {
                newEnemy.GetComponent<Alien>().HealthAmount = 1.0f;
            }
            
        }
    }
}
