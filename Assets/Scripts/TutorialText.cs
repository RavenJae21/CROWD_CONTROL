using UnityEngine;
using UnityEngine.UI;  // To interact with UI components

public class DialogueManager : MonoBehaviour
{
    public Text TutorialText;  // Reference to the Text component
    public Button nextButton;  // Reference to the Next button (optional)
    
    private string[] dialogueLines;  // Array to hold dialogue lines
    private int currentLineIndex = 0;  // Track which line of dialogue we are on

    void Start()
    {
        // Define the dialogue lines
        dialogueLines = new string[]
        {
            "Welcome to Crowd Control!","Your job is...crowd control!",
            "Give the people what they want!",
            "Feed these hungry savages as quickly as you can!"
        };
        
        // Update the dialogue text with the first line
        UpdateTutorialText();
        
        // Set up the button to call NextLine method on click
        if (nextButton != null)
        {
            nextButton.onClick.AddListener(NextLine);
        }
    }

    void UpdateTutorialText()
    {
        // Show the current dialogue line
        TutorialText.text = dialogueLines[currentLineIndex];
    }

    void NextLine()
    {
        // Move to the next line of dialogue
        currentLineIndex++;

        // If we've reached the end, stop or restart the dialogue
        if (currentLineIndex >= dialogueLines.Length)
        {
            currentLineIndex = 0;  // Optionally, restart from the beginning
            TutorialText.text = "The end of the dialogue.";
        }
        else
        {
            UpdateTutorialText();
        }
    }
}
