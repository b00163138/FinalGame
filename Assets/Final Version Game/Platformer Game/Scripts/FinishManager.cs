using UnityEngine;
using UnityEngine.SceneManagement;  // Required for SceneManager
using UnityEngine.UI;              // Required for Button references

public class FinishManager : MonoBehaviour
{
    // References to the buttons in your Finish Menu panel
    public Button mainMenuButton;
    public Button restartButton;
    public Button continueButton;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the Finish Menu panel is active
        gameObject.SetActive(true);

        // Assign button listeners
        if (mainMenuButton != null)
        {
            mainMenuButton.onClick.AddListener(GoToMainMenu);
        }

        if (restartButton != null)
        {
            restartButton.onClick.AddListener(RestartLevel);
        }

        if (continueButton != null)
        {
            continueButton.onClick.AddListener(ContinueToNextLevel);
        }
    }

    // Method to go to the Main Menu scene
    void GoToMainMenu()
    {
        // Since the Main Menu Scene doesn't exist yet, you can create it later
        // For now, this will log a message to the console
        Debug.Log("Main Menu Button Clicked! (Scene is not created yet)");

        // Uncomment this line when the Main Menu scene exists
        // SceneManager.LoadScene("MainMenu");
    }

    // Method to restart the current level
    public void RestartLevel()
    {
        Time.timeScale = 1f; // Ensure game time is normal
        AudioListener.pause = false; // Resume all audio
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Method to continue to the next level (Level-2)
    void ContinueToNextLevel()
    {
        // Since the Level-2 Scene doesn't exist yet, you can create it later
        // For now, this will log a message to the console
        SceneManager.LoadScene("Level2");

        // Uncomment this line when the Level-2 scene exists
        // SceneManager.LoadScene("Level-2");
    }
}
