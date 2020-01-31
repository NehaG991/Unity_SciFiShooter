using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienCollision : MonoBehaviour
{
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
