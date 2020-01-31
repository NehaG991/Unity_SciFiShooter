using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player; // stores reference to player

    private Vector3 offset; // variable stores offset distance between player and camera

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        // calculates and stores the offset value by getting the distance between the player and the camera
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
