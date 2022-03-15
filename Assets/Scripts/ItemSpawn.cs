using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject[] obstacle;           // This is an array/list, it will hold all future obstacles for the game

    private float spawnMinimum = 0.5f;
    private float spawnMaximum = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        Spawn();                            // Start the spawning of obstacles
    }

    void Spawn()
    {
        float rand = Random.Range(0, 100);  // First select a random number (to prevent predictability)

        if (rand > 50)                      
        {
            // Create a copy of the game obstacle in this place
            Instantiate(obstacle[Random.Range(0, obstacle.GetLength(0))], transform.position, Quaternion.identity);
        }

        // Run the spawn function again, after randomly selected seconds 
        Invoke("Spawn", Random.Range(spawnMinimum, spawnMaximum));          // Think of Invoke as a LOOP/iteration in this instance
    }
}
