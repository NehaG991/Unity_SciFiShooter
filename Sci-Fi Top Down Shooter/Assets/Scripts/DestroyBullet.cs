using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // Ends Bullet Explosion Animation/ Basically destroys animation
    void DestroyObject()
    {
        Destroy(gameObject);
    }
    
}
