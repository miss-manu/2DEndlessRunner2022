using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        // IF the replay button is clicked, reload the scene
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        // IF the quit button is clicked, end the game/close application
        Debug.Log("Game is QUIT!");
        Application.Quit();   // This only works after the game is built, thats why we include a Debug.Log statement
    }
}
