using UnityEngine;
using UnityEngine.SceneManagement; // Import SceneManager namespace

public class MainMenu : MonoBehaviour
{
    // Method to start the game
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1); // Load the scene with build index 1
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}