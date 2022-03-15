using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    // 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision was triggered by Player
        if (collision.CompareTag("Player"))
        {
            // Then pause the game & return to editor
            Debug.Break();
            return;
        }
        else if (collision.CompareTag("Prefab"))
        {
            //Debug.Log("Collision was caused by: " + collision.tag);     // Check a prefab caused the collision
            Destroy(collision.gameObject);                              // Then destroy the prefab
        }
    }
}
