using System.Collections.Generic;
using UnityEngine;
using TMPro;                                        // An important new library for accessing TextMeshPro

public class Score : MonoBehaviour
{
    public GameObject player;                       // A reference to our player object
    public TMP_Text scoreText;                      // A reference to the text in User interface
    private RobotController playerPosition;         
    private float playerScore = 0;
    private float pointsPerSecond = 10;

    public List<string> powerUpInventory;                       // Stores powerups collected 

    public static Score ScoreManager { get; private set; }

    private void Awake()
    {
        ScoreManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = player.GetComponent<RobotController>();        // A reference to the Robot Controller script, on our player
        powerUpInventory = new List<string>();                          // Set list component
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player has moved past the 'start' line (eg. The hand is started moving)
        if (player.transform.position.x > 2)
        {
            if (playerPosition.move != -1)  // Only add to the score if the player is NOT moving left/backwards
            {
                IncreaseScore(Time.deltaTime * pointsPerSecond);                      // Add 'metres' to our score
                DisplayScore(playerScore);
            }
        }  
    }

    
    public void IncreaseScore (float amount)
    {
        playerScore += amount;
    }


    public void DisplayScore (float score)
    {
        scoreText.text = "Score: " + ((int)(score)).ToString();            // Display the score in our interface
    }


    public void UpdateInventory(string bonusCollectable)
    {
        powerUpInventory.Add(bonusCollectable);
        print("You have collected a: " + bonusCollectable);                 // What item was collected?
        print("Inventory length: " + powerUpInventory.Count);               // What is the list count?
    }


    public void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)(playerScore));                    // Save the score, when the scene is changed (onDisable)
    }
}
