using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroy : MonoBehaviour
{
    Animator animator;                          // Reference to our objects animator component
    public float explodeRadius = 1f;            // Value for the explosion radius
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the bomb is done exploding (before destroying)
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Bomb_Dead"))
        {
            // Store all the objects in the radius (unless Player or Hand)
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explodeRadius);

            foreach(Collider2D col in colliders)
            {
                // Check if collider overlapped with player or hand
                if (col.tag != "Player" && col.tag != "Hand")
                {
                    // Destroy the objects
                    Destroy(col.gameObject);
                }
            }

            // Then make sure the object itself is deleted (eg. bomb)
            Destroy(this.gameObject);
        }
    }
}
