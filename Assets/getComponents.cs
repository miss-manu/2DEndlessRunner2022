using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getComponents : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite [] sprites;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rand = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        rend.color = Color.green;
        rend.sprite = sprites[rand];
    }
}
