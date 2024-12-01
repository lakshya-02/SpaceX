using UnityEngine;
using TMPro; // For TextMeshPro UI

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Reference to the TextMeshProUGUI component
    private MissileCon missileCon;     // Reference to the MissileCon script (where the score is stored)

    void Start()
    {
        // Assign the TextMeshProUGUI component attached to this GameObject
        scoreText = GetComponent<TextMeshProUGUI>();

        // Find the MissileCon script in the scene
        missileCon = FindObjectOfType<MissileCon>();

        // Check if the components are found to avoid null reference errors
        if (scoreText == null)
        {
            Debug.LogError("No TextMeshProUGUI component found on the object.");
        }

        if (missileCon == null)
        {
            Debug.LogError("No MissileCon script found in the scene.");
        }
    }

    void Update()
    {
        // Only update the score if the MissileCon reference is valid
        if (missileCon != null && scoreText != null)
        {
            // Update the UI with the score (num variable from MissileCon)
            scoreText.text = missileCon.num.ToString("0");

            // Optional: Debug to see if the score is updating correctly
            Debug.Log(missileCon.num);
        }
    }
}
