using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public string itemType;             // Name each of the power ups, so we can collect and score accordingly

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //First, check it was the player that collided with this item
        if (collision.CompareTag("Player"))
        {
            if (itemType == "Bike")
            {
                // Increase the score by 10
                Score.ScoreManager.IncreaseScore(10);               // Accesses the score script and Increase score
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
            else if (itemType == "Chip")
            {
                // Increase the score by 100
                Score.ScoreManager.IncreaseScore(100);
            }

            // Add item to a scoring inventory
            Score.ScoreManager.UpdateInventory(itemType);
            Destroy(this.gameObject);
        }
    }
}
