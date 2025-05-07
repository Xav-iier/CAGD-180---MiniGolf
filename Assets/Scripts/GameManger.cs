using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    // Assign this in the Inspector 
    public TextMeshProUGUI strokeText;

    // Public so other scripts can read it if they want 
    public int strokeCount { get; private set; } = 0;

    // Initialise the UI once the scene starts 
    void Start() => UpdateStrokeUI();

    // Called by ClubController every time you hit the ball 
    public void AddStroke(int amount = 1)
    {
        strokeCount += amount;
        UpdateStrokeUI();
    }

    public void ResetStrokes()
    {
        strokeCount = 0;
        UpdateStrokeUI();
    }

    void UpdateStrokeUI()
    {
        if (strokeText)
            strokeText.text = "Stroke: " + strokeCount;
    }
}


