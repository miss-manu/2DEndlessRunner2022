using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    private int finalScore = 0;
    private TMP_Text scoreDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        finalScore = PlayerPrefs.GetInt("Score");
        scoreDisplay = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void OnGUI()
    {
        scoreDisplay.text = finalScore.ToString();

    }
}
