using UnityEngine;

[System.Serializable]
public class TarotCard
{
    public string cardName;      // Name of the card (e.g., The Fool)
    public int cardNumber;       // Number of the card in Major Arcana
    public Sprite cardImage;     // Image of the card (assigned in Unity)
    public string description;   // Description or meaning of the card
    public string wisdom;        // Life lesson or wisdom associated with the card
}
