using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] obstacle;               // This is an array/list, it will hold all future obstacles for the game

    public float spawnMinimum = 0.05f;
    public float spawnMaximum = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        Spawn();                                // Start the spawning of obstacles
    }

    // Update is called once per frame
    void Spawn()
    {
        float rand = Random.Range(0, 100);      // First, select a random number (to prevent predictability of spawned obstacles)

        if (rand < 50)
        {
            // Create a copy of the game obstacle in this place
            Instantiate(obstacle[Random.Range(0, obstacle.GetLength(0))], transform.position, Quaternion.identity);
        }

        // Run the Spawn function again, after randomly selected seconds
        Invoke("Spawn", Random.Range(spawnMinimum, spawnMaximum));              // Think of this as a LOOP/ITERATION cycle of this method
    }
}
