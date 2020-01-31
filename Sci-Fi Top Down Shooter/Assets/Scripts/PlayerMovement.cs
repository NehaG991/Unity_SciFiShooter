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

    //private bool isDead;

    public void Start()
    {
        content = GameObject.Find("content").GetComponent<Image>();
    }


    private void Update()
    {

            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            verticalMove = Input.GetAxis("Vertical") * speed;


            animator.SetFloat("Speed", Mathf.Abs(verticalMove));


            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

            if (content.fillAmount <= 0.01f)
            {
                Destroy(gameObject);
                //animator.SetTrigger("dead");
                //isDead = true;
            }
        

    }

    // fixedUpdate is called at a fixed interval; indepedent of frame rate; put phsyics code here
    private void FixedUpdate()
    {



            rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);


            Vector2 lookDir = mousePos - rb2d.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            rb2d.rotation = angle;
        

    }
}
