using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // This function will be called when the "Play" button is clicked.
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    // This function will be called when the "Quit" button is clicked.
    public void QuitGame()
    {
        // Logs a message in the editor for testing purposes.
        Debug.Log("Quit Game");

        // Closes the application (works in builds only).
        Application.Quit();
    }
    public void GoInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
