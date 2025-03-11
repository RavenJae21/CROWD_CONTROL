using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timerText;           // Reference to the Timer Text UI
    public Slider timerSlider;       // Reference to the Timer Slider UI
    public Text scoreText;           // Reference to the Score Text UI
    public float gameTime = 30f;     // Time for the game to run (30 seconds)
    private float timeRemaining;     // Time remaining in the game
    private int score = 0;           // Player's score

    void Start()
    {
        timeRemaining = gameTime;
        timerSlider.maxValue = gameTime; // Set slider max value to 30 seconds
        timerSlider.value = gameTime;    // Set the slider's current value to 30 seconds

        // Initialize the score display
        UpdateScoreText();
        UpdateTimerText();
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;  // Decrease the time each frame
            timerSlider.value = timeRemaining; // Update the slider to reflect the time remaining
            UpdateTimerText();
        }
        else
        {
            timeRemaining = 0;
            // Game over logic here (e.g., stop spawning Expoints, display final score)
            Debug.Log("Game Over! Final Score: " + score);
        }
    }

    // Update the Timer Text UI
    void UpdateTimerText()
    {
        timerText.text = Mathf.Ceil(timeRemaining).ToString() + "s";  // Show remaining time in seconds
    }

    // Update the Score Text UI
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    // Call this method to increase the score when an "Expoint" is hit
    public void IncreaseScore()
    {
        score++;
        UpdateScoreText();
    }
}

