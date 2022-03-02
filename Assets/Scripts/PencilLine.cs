using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilLine : MonoBehaviour
{
    public GameObject linePrefab;   // Make reference to our pencil line 

    float lastX = 0f;               // Previous axis of pencil line
    float pencilLength = 0.04f;     // Length of the pencil sprite
    
    // Update is called once per frame
    void Update()
    {
        // Check if the robot has moved to start drawing line
        if (transform.position.x > (lastX + pencilLength))
        {
            // Make a copy of the prefab
            Instantiate(linePrefab, transform.position, Quaternion.identity);
            lastX = transform.position.x;
        }
    }
}
