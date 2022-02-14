using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float maxSpeed = 2f;                 // This will be our maximum Robot speed
    private float move = 0f;                    // Sets robot to still on entry

    bool facingLeft = true;                     //

    Rigidbody2D rb;                             
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");  // Gives the a value of 1 or -1 when we use arrow keys
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        if (move < 0 && !facingLeft)
        {
            Flip();
        }
        else if (move > 0 && facingLeft)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
