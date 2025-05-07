using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManger : MonoBehaviour
{
        public int lives = 3;
        public TextMeshProUGUI livesText;

        private void Start()
        {
            UpdateLivesUI(); // Ensure UI updates at game start
        }

        public void LoseLife()
        {
            if (lives > 0)
            {
                lives--;
                UpdateLivesUI(); // Update UI whenever lives decrease
            }
        }
     
        private void UpdateLivesUI()
        {
            if (livesText != null)
            {
                livesText.text = "Lives: " + lives;
            }
        }
}


