using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float maxSpeed = 2f;                 // This will be our maximum Robot speed
    private float move = 0f;                    // Sets robot to still on entry

    bool facingLeft = true;                     // Set the direction of player sprite

    Rigidbody2D rigidBody2d;
    Animator animator;

    // To check ground & values for use in Editor
    bool grounded = false;                      
    public Transform groundCheck;               // Check position is on ground
    float groundRadius = 0.9f;                  // Scan for proximity of position to ground
    public LayerMask whatIsGround;              // Determine ground for player
    public float jumpForce = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for player LR movement
        move = Input.GetAxisRaw("Horizontal");

        // Check for player jump input
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            PlayerJump();
        }

    }

    void FixedUpdate()
    {
        // Move player
        rigidBody2d.velocity = new Vector2(move * maxSpeed, rigidBody2d.velocity.y);

        // Check player is on the ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        // Player animations
        animator.SetFloat("Speed", Mathf.Abs(move));
        animator.SetFloat("vSpeed", rigidBody2d.velocity.y);
        animator.SetBool("Ground", grounded);

        // Flip Player to direction of movement
        if (move < 0 && !facingLeft)
        {
            PlayerFlip();
        }
        else if (move > 0 && facingLeft)
        {
            PlayerFlip();
        }
              
    }

    // Flip the player
    void PlayerFlip()
    {
        facingLeft = !facingLeft;
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void PlayerJump()
    {
        rigidBody2d.AddForce(new Vector2(0, jumpForce));
    }
}
