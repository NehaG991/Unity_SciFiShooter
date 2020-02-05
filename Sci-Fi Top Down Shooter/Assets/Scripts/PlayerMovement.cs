using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    public Rigidbody2D rb2d;
    public Camera cam;

    float verticalMove = 0f;

    public Image content;


    Vector2 movement;
    Vector2 mousePos;

    public Animator animator;

    public void Start()
    {
        content = GameObject.Find("content").GetComponent<Image>();
    }


    private void Update()
    {
            // gets the x and y axis of the player and plays the movement animation if the player is moving
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            verticalMove = Input.GetAxis("Vertical") * speed;
            animator.SetFloat("Speed", Mathf.Abs(verticalMove));

            // gets the mouse position
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            
            // destroys the player object is the health is less than 1%
            if (content.fillAmount <= 0.01f)
            {
                Destroy(gameObject);
           
            }
        

    }

    // fixedUpdate is called at a fixed interval; indepedent of frame rate; put phsyics code here
    private void FixedUpdate()
    {


            // moves the rigidbody of the player based on its current position and speed at a fixed time interval
            rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);

            // makes the front of the player sprite follow the mouse position
            Vector2 lookDir = mousePos - rb2d.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            rb2d.rotation = angle;
        

    }
}
