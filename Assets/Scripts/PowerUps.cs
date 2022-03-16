using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public string itemType;                 // Name each of the power ups, so we can collect and score accordingly

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // First, check if it was the player that collided with this item
        if (collision.CompareTag("Player"))
        {
            if (itemType == "Bike")
            {
                // Increase the score by 10
                Score.ScoreManager.IncreaseScore(10);               // Reference to another script, with the method IncreaseScore
            }
            else if (itemType == "Plane")
            {
                // Increase the score by 15
                Score.ScoreManager.IncreaseScore(15);
            }
            else if (itemType == "Dinner")
            {
                // Increase the score by 20
                Score.ScoreManager.IncreaseScore(20);
            }
            else if (itemType == "House")
            {
                // Increase the score by 25
                Score.ScoreManager.IncreaseScore(25);
            }
            else if (itemType == "Works")
            {
                // Increase the score by 50
                Score.ScoreManager.IncreaseScore(50);
            }
            else if (itemType == "Circuit")
            {
                // Increase the score by 100
                Score.ScoreManager.IncreaseScore(100);
            }

            // Increase the score by 10
            Score.ScoreManager.UpdateInventory(itemType);
            Destroy(this.gameObject);
        }
    }
}
