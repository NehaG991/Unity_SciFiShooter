using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollosion : MonoBehaviour
{
    // starts explosion animation on collision

    public GameObject collid; 

    void OnCollisionEnter2D(Collision2D collision)
    {

        // creates bullet explosion
        GameObject effect = Instantiate(collid, transform.position, Quaternion.identity);
        
        // destroy both the original bullet and the explosion
        Destroy(effect, 5f);
        Destroy(gameObject);
    }


}
