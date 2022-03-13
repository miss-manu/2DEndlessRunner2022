using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public string itemType;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (itemType == "Bike")
            {
                Score.ScoreManager.IncreaseScore(100);
            }
            else if (itemType == "Plane")
            {
                Score.ScoreManager.IncreaseScore(200);
            }
            else if (itemType == "Dinner")
            {
                Score.ScoreManager.IncreaseScore(300);
            }
            else if (itemType == "House")
            {
                Score.ScoreManager.IncreaseScore(400);
            }
            else if (itemType == "Works")
            {
                Score.ScoreManager.IncreaseScore(500);
            }
            else if (itemType == "Circuit")
            {
                Score.ScoreManager.IncreaseScore(1000);
            }

            Destroy(this.gameObject);
            Score.ScoreManager.UpdateInventory(itemType);
        }
    }
}
