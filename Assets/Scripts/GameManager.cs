using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool IsGameOver = false; // Flag to check if the game is over

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        IsGameOver = true; // Set the game over flag to true

        // Load the game over scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
