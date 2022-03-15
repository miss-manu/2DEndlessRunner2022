using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    float yDirection = 0f;          // Position of camera placement
    float randomY = 0f;             // Random Y position
    public float cameraSpeed = 0.06f;      // Speed of camera movement

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        // Check if the player still exists
        if (player)
        {
            // Check if player has moved forwards to start camera move
            if (player.transform.position.x > 2)
            {
                randomY = Random.Range(0f, 75f);

                // Set how the camera will randomly move forward
                if (randomY < 25)
                {
                    yDirection = yDirection + .005f;
                }
                else if (randomY > 25 && randomY < 50)
                {
                    yDirection = yDirection - .005f;
                }
                else
                {
                    yDirection = 0f;
                }

                // Tells the camera to move to the new position, when the frame update
                transform.position = new Vector3(transform.position.x + cameraSpeed, transform.position.y + yDirection, -10);
            }
        }
    }
}
