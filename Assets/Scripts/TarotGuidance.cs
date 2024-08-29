using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TarotGuidance : MonoBehaviour
{
    [SerializeField] private TarotGameManager tarotGameManager;
    [SerializeField] private Canvas canvas;
    [SerializeField] private TextMeshProUGUI guidanceText;
    [SerializeField] private GameObject guidancePanel;
    [SerializeField] private Button menuButton;
    [SerializeField] private AudioSource backgroundMusic;

    private void Start()
    {
        menuButton.onClick.AddListener(MainMenu);
    }

    public void DisplayGuidance()
    {
        if (canvas != null)
        {
            DisableAllChildren(canvas.gameObject);
        }

        backgroundMusic.Play();

        // Make the guidance panel visible
        guidancePanel.SetActive(true);

        // Generate and display the guidance text
        string guidance = GenerateGuidance();
        guidanceText.text = guidance;
    }

    // Method to generate the guidance text based on the drawn cards
    private string GenerateGuidance()
    {
        // Retrieve the drawn cards from the TarotGameManager
        TarotCard pastCard = tarotGameManager.GetPastCard();
        TarotCard presentCard = tarotGameManager.GetPresentCard();
        TarotCard futureCard = tarotGameManager.GetFutureCard();

        // Generate the guidance text
        string guidance = "";
        guidance += InterpretCard(pastCard, "Past") + "\n\n";
        guidance += InterpretCard(presentCard, "Present") + "\n\n";
        guidance += InterpretCard(futureCard, "Future");

        return guidance;
    }

    // Method to generate wisdom-based interpretation for each card
    private string InterpretCard(TarotCard card, string timePeriod)
    {
        // Generate the interpretation text
        string interpretation = $"<b>{timePeriod} - {card.cardName}</b>";
        interpretation += $"\n\nWisdom: {card.wisdom}";

        // Add reflection based on the time period
        if (timePeriod == "Past")
        {
            interpretation += "\n\nReflection: Consider how this wisdom has shaped your past decisions and experiences.";
        }
        else if (timePeriod == "Present")
        {
            interpretation += "\n\nReflection: Apply this wisdom to your current situation and reflect on how it can guide your actions.";
        }
        else if (timePeriod == "Future")
        {
            interpretation += "\n\nReflection: Keep this wisdom in mind as you move forward. Let it inform your choices and prepare you for what’s to come.";
        }

        interpretation += "\n\n";

        return interpretation;
    }

    private void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    void DisableAllChildren(GameObject parent)
    {
        // Loop through each child GameObject under the Canvas
        foreach (Transform child in parent.transform)
        {
            // Disable the child GameObject
            child.gameObject.SetActive(false);
        }
    }

}
