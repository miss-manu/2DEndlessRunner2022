using UnityEngine;
using TMPro;                                         // An important new library for accessing TextMeshPro

public class Score : MonoBehaviour
{
    public GameObject player;                       // A reference to our player object
    public TMP_Text scoreText;                      // A reference to the text in User interface
    private RobotController playerPosition;         
    private float playerScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = player.GetComponent<RobotController>();        // A reference to the Robot Controller script, on our player
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player has moved past the 'start' line (eg. The hand is started moving)
        if (player.transform.position.x > 2)
        {
            if (playerPosition.move != -1)  // Only add to the score if the player is NOT moving left/backwards
            {
                playerScore += Time.deltaTime;                                          // Add 'metres' to our score
                scoreText.text = "Score: " + ((int)(playerScore * 10)).ToString();      // Display the score in our interface
            }
        }  
    }
}
