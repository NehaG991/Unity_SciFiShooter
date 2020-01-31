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



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > nextSpawn)
        {
            
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            GameObject newEnemy = Instantiate(enemy, whereToSpawn, Quaternion.identity);
            newEnemy.transform.parent = parent.transform;

            if (newEnemy.CompareTag("Enemy"))
            {
                newEnemy.GetComponent<Alien>().HealthAmount = 1.0f;
            }
            
        }
    }
}
