using System.Collections.Generic;                   // We will need to add some standard features of C# back in our script
using UnityEngine;
using TMPro;                                         // An important new library for accessing TextMeshPro

public class Score : MonoBehaviour
{
    public GameObject player;                       // A reference to our player object
    public TMP_Text scoreText;                      // A reference to the text in User interface
    private RobotController playerPosition;         
    private float playerScore = 0;
    private float pointsPerSecond = 10f;            

    public List<string> powerUpInventory;           // A container to hold the items we collect

    public static Score ScoreManager { get; private set; }

    private void Awake()
    {
        // When game starts, set a reference to method called ScoreManager in this script
        ScoreManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = player.GetComponent<RobotController>();        // A reference to the Robot Controller script, on our player
        powerUpInventory = new List<string>();                          // A reference to the new list/array we will create
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player has moved past the 'start' line (eg. The hand is started moving)
        if (player.transform.position.x > 2)
        {
            if (playerPosition.move != -1)  // Only add to the score if the player is NOT moving left/backwards
            {
                IncreaseScore(Time.deltaTime * pointsPerSecond);
                DisplayScore(playerScore);
            }
        }  
    }

    public void IncreaseScore(float amount)
    {
        playerScore += amount;                                  // Add 'metres' to our score
    }

    public void DisplayScore(float score)
    {
        scoreText.text = "Score: " + ((int)(score)).ToString();      // Display the score in our interface
    }

    public void UpdateInventory(string powerUpCollectable)
    {
        powerUpInventory.Add(powerUpCollectable);
        print("You have collected a: " + powerUpCollectable);
        print("Your inventory length is: " + powerUpInventory.Count);
    }
}
