using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyRotation : MonoBehaviour
{
    // flips the enemy based on the direction the enemy is going

    public AIPath path;

    // Update is called once per frame
    void Update()
    {

        if (path.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f,1f);
        }
        else if (path.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
