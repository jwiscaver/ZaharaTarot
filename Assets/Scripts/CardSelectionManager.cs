using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class CardSelectionManager : MonoBehaviour
{
    [Header("Card Settings")]
    [SerializeField] private GameObject cardPrefab;        // Prefab for the cards
    [SerializeField] private Transform cardFanLayout;      // Parent for fanned-out cards
    [SerializeField] private Sprite cardBackImage;         // Card back image to display for all cards

    [Header("Selection Settings")]
    [SerializeField] private int maxSelectableCards = 3;   // Max number of selectable cards
    [SerializeField] private float moveUpDistance = 20f;   // Distance to move the card when selected
    [SerializeField] private float overlapAmount = 30f;    // Amount of overlap between cards

    [Header("Shuffle Settings")]
    [SerializeField] private float shuffleDuration = 2f;    // Duration for the shuffle animation
    [SerializeField] private float shuffleRange = 400f;     // Range of random positions during shuffle
    [SerializeField] private float fanOutDuration = 1.5f;   // Duration for the fan-out effect after shuffling
    [SerializeField] private Vector2 offScreenPosition = new Vector2(-1000, 0);  // Initial off-screen position for cards

    [Header("UI Settings")]
    [SerializeField] private TextMeshProUGUI instructionsText;  // Reference to the instructions TextMeshPro
    [SerializeField] private Button continueButton;

    [Header("Audio Settings")]
    [SerializeField] private AudioSource shuffleSound;
    [SerializeField] private AudioSource cardSelectSound;
    [SerializeField] private AudioSource cardDeselectSound; 

    private List<GameObject> cards = new List<GameObject>();  // List to store the instantiated cards
    private List<GameObject> selectedCards = new List<GameObject>();  // List to store selected cards

    private void Start()
    {
        // Hide the instructions text at the start
        instructionsText.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        continueButton.onClick.AddListener(Continue);

        // Instantiate 22 cards and store them in the cards list
        for (int i = 0; i < 22; i++)
        {
            GameObject card = Instantiate(cardPrefab, cardFanLayout);
            card.GetComponent<Image>().sprite = cardBackImage;  // Set the card back image

            RectTransform cardTransform = card.GetComponent<RectTransform>();

            // Position the card off-screen initially (to hide it)
            cardTransform.anchoredPosition = offScreenPosition;

            // Add the Button component if it doesn't already exist
            Button cardButton = card.GetComponent<Button>();
            if (cardButton == null) cardButton = card.AddComponent<Button>();

            // Add the click event to the card
            cardButton.onClick.AddListener(() => OnCardSelected(card));

            cards.Add(card);  // Add the card to the list
        }

        // Start the shuffle animation before fanning out
        StartCoroutine(ShuffleCards());
    }

    // Handle the card selection
    private void OnCardSelected(GameObject selectedCard)
    {
        // If the card is already selected, deselect it
        if (selectedCards.Contains(selectedCard))
        {
            cardDeselectSound.Play();
            DeselectCard(selectedCard);
            selectedCards.Remove(selectedCard);
        }
        // If less than 3 cards are selected, select the card
        else if (selectedCards.Count < maxSelectableCards)
        {
            cardSelectSound.Play();
            SelectCard(selectedCard);
            selectedCards.Add(selectedCard);
        }

        if (selectedCards.Count == maxSelectableCards)
        {
            continueButton.gameObject.SetActive(true);
        }
        else
        {
            continueButton.gameObject.SetActive(false);
        }
    }

    // Move the card up when selected
    private void SelectCard(GameObject card)
    {
        RectTransform cardTransform = card.GetComponent<RectTransform>();
        cardTransform.anchoredPosition += new Vector2(0, moveUpDistance);
    }

    // Move the card back down when deselected
    private void DeselectCard(GameObject card)
    {
        RectTransform cardTransform = card.GetComponent<RectTransform>();
        cardTransform.anchoredPosition -= new Vector2(0, moveUpDistance);
    }

    // Coroutine to shuffle the cards with a random movement
    private IEnumerator ShuffleCards()
    {
        // First, move all cards to random positions to simulate shuffling
        foreach (GameObject card in cards)
        {
            RectTransform cardTransform = card.GetComponent<RectTransform>();
            Vector2 randomPosition = new Vector2(
                Random.Range(-shuffleRange, shuffleRange),
                Random.Range(-shuffleRange, shuffleRange)
            );
            StartCoroutine(MoveCard(cardTransform, randomPosition, shuffleDuration));
        }

        // Wait for the shuffle duration to finish
        yield return new WaitForSeconds(shuffleDuration);

        // Fan out the cards after shuffling
        FanOutCards();
    }

    // Coroutine to move the card to a target position smoothly
    private IEnumerator MoveCard(RectTransform cardTransform, Vector2 targetPosition, float duration)
    {
        Vector2 startPosition = cardTransform.anchoredPosition;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            // Using SmoothStep for smoother easing between positions
            float t = Mathf.SmoothStep(0f, 1f, elapsedTime / duration);
            cardTransform.anchoredPosition = Vector2.Lerp(startPosition, targetPosition, t);
            yield return null;
        }

        // Ensure it ends exactly at the target position
        cardTransform.anchoredPosition = targetPosition;
    }

    // Fan out the cards after the shuffle with slight overlap
    private void FanOutCards()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            if (i==4)
            {
                shuffleSound.Play();
            }

            RectTransform cardTransform = cards[i].GetComponent<RectTransform>();
            Vector2 fanOutPosition = new Vector2(i * overlapAmount, 0);
            StartCoroutine(MoveCard(cardTransform, fanOutPosition, fanOutDuration));
        }

        // Show the instructions text after the fan-out is done
        StartCoroutine(ShowInstructionsAfterDelay(fanOutDuration));
    }

    // Coroutine to show the instructions after the fan-out is complete
    private IEnumerator ShowInstructionsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        instructionsText.gameObject.SetActive(true);
    }

    private void Continue()
    {
        SceneManager.LoadScene("Tarot");
    }
}
