using UnityEngine;
using UnityEngine.UI;  // For UI components

public class TimerManager : MonoBehaviour
{
    public Text timerText;  // Reference to the Text component that shows time
    public Slider timerSlider;  // Reference to the Slider for visual countdown

    private float timeRemaining = 30f;  // Total time for the countdown (30 seconds)
    private bool timerRunning = false;  // Whether the timer is running

    void Start()
    {
        // Initialize the slider with the max value and starting value (30 seconds)
        timerSlider.maxValue = timeRemaining;
        timerSlider.value = timeRemaining;
        
        // Start the timer
        timerRunning = true;
    }

    void Update()
    {
        // If the timer is running, decrement the time
        if (timerRunning)
        {
            timeRemaining -= Time.deltaTime;  // Decrease the time by the frame time

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                timerRunning = false;  // Stop the timer when time reaches 0
            }

            // Update the UI elements
            timerText.text = Mathf.Ceil(timeRemaining).ToString() + "s";  // Display remaining time in seconds
            timerSlider.value = timeRemaining;  // Update the slider's value
        }
    }
}

