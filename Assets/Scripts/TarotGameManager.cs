using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TarotGameManager : MonoBehaviour
{
    private TarotCard pastCard;
    private TarotCard presentCard;
    private TarotCard futureCard;

    [Header("Deck and Slot")]
    [SerializeField] private TarotDeck tarotDeck;
    [SerializeField] private Transform cardSlot;
    [SerializeField] private GameObject cardPrefab;

    [Header("Audio Settings")]
    [SerializeField] private AudioSource dealCardSound;

    [Header("UI Elements")]
    [SerializeField] private Button nextCardButton;  
    [SerializeField] private Button guidanceButton;

    private int currentCardIndex = 0;

    private void Start()
    {
        tarotDeck.ShuffleDeck();

        // Draw three cards
        pastCard = tarotDeck.cards[0];
        presentCard = tarotDeck.cards[1];
        futureCard = tarotDeck.cards[2];

        ClearCardSlot();

        nextCardButton.gameObject.SetActive(true);  
        guidanceButton.gameObject.SetActive(false);

        // Add listener for Next Card button
        nextCardButton.onClick.AddListener(DisplayNextCard);

        // Add listener for the Guidance button
        guidanceButton.onClick.AddListener(FindObjectOfType<TarotGuidance>().DisplayGuidance);

        DisplayNextCard();  // Start with the first card
    }


    private void ClearCardSlot()
    {
        foreach (Transform child in cardSlot) Destroy(child.gameObject);
    }

    private void DisplayNextCard()
    {
        ClearCardSlot();

        switch (currentCardIndex)
        {
            case 0:
                DisplayCard(pastCard, "Past");
                break;
            case 1:
                DisplayCard(presentCard, "Present");
                break;
            case 2:
                DisplayCard(futureCard, "Future");
                nextCardButton.gameObject.SetActive(false);  // Hide the next button after all cards are revealed
                guidanceButton.gameObject.SetActive(true);  // Show the finish button, but it is now handled by TarotGuidance
                break;
        }

        dealCardSound.Play();
        currentCardIndex++;
    }

    private void DisplayCard(TarotCard cardData, string timePeriod)
    {
        GameObject cardObject = Instantiate(cardPrefab, cardSlot);
        cardObject.GetComponent<Image>().sprite = cardData.cardImage;
        cardObject.transform.Find("CardTypeTextTMP").GetComponent<TextMeshProUGUI>().text = timePeriod;
        cardObject.transform.Find("CardNameTextTMP").GetComponent<TextMeshProUGUI>().text = cardData.cardName;
        cardObject.transform.Find("CardDescriptionTextTMP").GetComponent<TextMeshProUGUI>().text = cardData.description;
    }

    // Methods to access the drawn cards
    public TarotCard GetPastCard() { return pastCard; }
    public TarotCard GetPresentCard() { return presentCard; }
    public TarotCard GetFutureCard() { return futureCard; }
}
