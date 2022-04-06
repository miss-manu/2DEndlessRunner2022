using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    private int finalScore = 0;
    private TMP_Text scoreDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        finalScore = PlayerPrefs.GetInt("Score");        // Get the final score from the game over scene
        scoreDisplay = GetComponent<TMP_Text>();
    }

    private void OnGUI()
    {
        // Display the final score in UI
        scoreDisplay.text = finalScore.ToString();
    }
}
