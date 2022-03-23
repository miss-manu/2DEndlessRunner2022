using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOffScreen : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision was triggered by Player
        if (collision.CompareTag("Player"))
        {
            // run a game over animation?
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);      // Change the scene to gameover
            
        }
        else if (collision.CompareTag("Prefab"))
        {
            //Debug.Log("Collision was caused by: " + collision.tag);     // Check a prefab caused the collision
            Destroy(collision.gameObject);                                // Then destroy the prefab
        }
    }
}
