using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollosion : MonoBehaviour
{
    // starts explosion animation on collision

    public GameObject collid; 

    void OnCollisionEnter2D(Collision2D collision)
    {


        GameObject effect = Instantiate(collid, transform.position, Quaternion.identity);

        Destroy(effect, 5f);
        Destroy(gameObject);
    }


}
