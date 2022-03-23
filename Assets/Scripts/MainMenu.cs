using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        PlayerPrefs.DeleteKey("Score");             // Delete the high score, only on quitting
        Application.Quit();
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("GameMenu", LoadSceneMode.Single);
    }
}
