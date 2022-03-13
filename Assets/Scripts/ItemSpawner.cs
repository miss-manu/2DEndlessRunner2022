using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] obstacle;               // A public array from which objects can be spawned

    public float spawnMinimum = 3f;
    public float spawnMaximum = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Spawn()
    {
        float rand = Random.Range(0, 100);

        if (rand < 50)
        {
            Instantiate(obstacle[Random.Range(0, obstacle.GetLength(0))], transform.position, Quaternion.identity);
        }

        Invoke("Spawn", Random.Range(spawnMinimum, spawnMaximum));
    }
}
