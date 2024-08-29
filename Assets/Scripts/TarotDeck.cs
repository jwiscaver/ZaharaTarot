using System.Collections.Generic;
using UnityEngine;

public class TarotDeck : MonoBehaviour
{
    public List<TarotCard> cards = new List<TarotCard>();

    private void Awake()
    {
        PopulateCardList();
    }

    private void PopulateCardList()
    {
        cards.Add(new TarotCard
        {
            cardName = "The Fool.",
            cardNumber = 0,
            description = "The Fool represents new beginnings, spontaneity, and adventure.\n\nIt encourages embracing the unknown with an open heart.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-fool"),
            wisdom = "Embrace new beginnings without fear. Trust in the journey ahead, even if the path seems uncertain. Sometimes, not knowing where you're going is part of the adventure."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Magician.",
            cardNumber = 1,
            description = "The Magician symbolizes power, skill, and resourcefulness.\n\nIt suggests using your talents to manifest your desires.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-magician"),
            wisdom = "You have all the tools you need to succeed. Believe in your ability to manifest your desires and shape your destiny with willpower and focused intention."
        });

        cards.Add(new TarotCard
        {
            cardName = "The High Priestess.",
            cardNumber = 2,
            description = "The High Priestess represents intuition, wisdom, and the subconscious mind.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-highpriestess"),
            wisdom = "Listen to your inner voice and trust your intuition. Not everything can be explained logically—some truths must be felt or discovered in quiet reflection."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Empress.",
            cardNumber = 3,
            description = "The Empress embodies fertility, abundance, and creativity.\n\nShe symbolizes nurturing and the growth of new life.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-empress"),
            wisdom = "Nurture your creativity and allow yourself to grow. Abundance flows when you embrace a mindset of care, love, and patience, both for yourself and others."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Emperor.",
            cardNumber = 4,
            description = "The Emperor stands for authority, structure, and stability.\n\nHe represents leadership and the power of reason.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-emperor"),
            wisdom = "Create order in your life and take charge of your circumstances. Structure, discipline, and authority are necessary to build a solid foundation."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Hierophant.",
            cardNumber = 5,
            description = "The Hierophant signifies tradition, religion, and spiritual guidance.\n\nHe encourages seeking wisdom from a trusted source.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-hierophant"),
            wisdom = "Seek wisdom from tradition, mentors, or spiritual teachings. Sometimes, the guidance of established values or rituals can lead to greater understanding and insight."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Lovers.",
            cardNumber = 6,
            description = "The Lovers symbolize love, harmony, and choices.\n\nIt reflects important decisions in relationships and alignment with values.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-lovers"),
            wisdom = "Life often presents choices that require careful consideration. Balance the head and the heart, and remember that relationships are built on trust, communication, and harmony."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Chariot.",
            cardNumber = 7,
            description = "The Chariot stands for determination, willpower, and victory.\n\nIt indicates overcoming obstacles through focus and control.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-chariot"),
            wisdom = "Determination and self-discipline will help you overcome obstacles. Stay focused on your goals, but remember that true strength comes from mastering both inner and outer challenges."
        });

        cards.Add(new TarotCard
        {
            cardName = "Justice.",
            cardNumber = 8,
            description = "Justice represents fairness, truth, and law.\n\nIt suggests a need for balance and making ethical decisions.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-justice"),
            wisdom = "Life is a reflection of your actions. Strive for fairness, truth, and honesty in all matters, and trust that what you give to the world will return to you in kind."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Hermit.",
            cardNumber = 9,
            description = "The Hermit symbolizes introspection, solitude, and inner guidance.\n\nIt advises taking time to reflect and seek personal wisdom.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-hermit"),
            wisdom = "Step back from the noise of the world to find clarity within yourself. Solitude, introspection, and reflection can bring deep understanding and personal growth."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Wheel of Fortune.",
            cardNumber = 10,
            description = "The Wheel of Fortune signifies change, cycles, and destiny.\n\nIt reminds you that life is constantly evolving, and luck is a part of it.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-wheeloffortune"),
            wisdom = "Life is cyclical, and change is inevitable. Embrace the highs and lows, knowing that nothing stays the same forever. Adaptability and acceptance will bring you peace."
        });

        cards.Add(new TarotCard
        {
            cardName = "Strength.",
            cardNumber = 11,
            description = "Strength represents courage, patience, and self-confidence.\n\nIt highlights the power of compassion and inner strength to overcome challenges.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-strength"),
            wisdom = "True strength comes from within. It’s not about control or force but about patience, compassion, and inner resilience, especially in difficult times."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Hanged Man.",
            cardNumber = 12,
            description = "The Hanged Man stands for surrender, letting go, and gaining a new perspective.\n\nIt encourages patience and looking at situations differently.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-hangedman"),
            wisdom = "Sometimes, progress requires surrender. Let go of old ways of thinking, and be willing to view situations from a new perspective. In letting go, you may gain more than you imagined."
        });

        cards.Add(new TarotCard
        {
            cardName = "Death.",
            cardNumber = 13,
            description = "Death symbolizes transformation, endings, and new beginnings.\n\nIt represents the closure of one chapter and the start of another.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-death"),
            wisdom = "Transformation is essential for growth. Embrace the natural endings in life, as they pave the way for new beginnings and a deeper understanding of yourself."
        });

        cards.Add(new TarotCard
        {
            cardName = "Temperance.",
            cardNumber = 14,
            description = "Temperance signifies balance, moderation, and harmony.\n\nIt encourages patience and finding equilibrium in your life.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-temperance"),
            wisdom = "Seek balance in all things. Moderation, patience, and harmony are key to a fulfilling life. Don’t rush—everything unfolds in its own time."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Devil.",
            cardNumber = 15,
            description = "The Devil represents materialism, bondage, and temptation.\n\nIt reminds you to be mindful of unhealthy attachments or destructive behavior.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-devil"),
            wisdom = "Be mindful of what controls you. Whether it’s materialism, fear, or unhealthy attachments, freeing yourself from negative influences is essential for personal freedom."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Tower.",
            cardNumber = 16,
            description = "The Tower represents sudden change, upheaval, and revelation.\n\nIt often signifies a breakthrough that leads to a deeper understanding.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-tower"),
            wisdom = "Sudden change, though painful, can be a blessing in disguise. When old structures fall apart, new opportunities arise. Embrace the chaos as a chance to rebuild something stronger."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Star.",
            cardNumber = 17,
            description = "The Star stands for hope, inspiration, and renewal.\n\nIt suggests a time of healing and looking towards the future with optimism.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-star"),
            wisdom = "There is always hope, even in dark times. Trust in the universe and in your inner light to guide you toward renewal and inspiration. Keep faith in your dreams."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Moon.",
            cardNumber = 18,
            description = "The Moon symbolizes intuition, illusions, and the subconscious.\n\nIt encourages trusting your instincts and exploring hidden truths.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-moon"),
            wisdom = "Not everything is as it seems. Be aware of illusions, fears, and the influence of the subconscious. Trust your instincts, but seek clarity before making decisions."
        });

        cards.Add(new TarotCard
        {
            cardName = "The Sun.",
            cardNumber = 19,
            description = "The Sun represents positivity, success, and vitality.\n\nIt signifies joy, clarity, and the ability to overcome any darkness.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-sun"),
            wisdom = "Positivity and joy are within reach. Celebrate your successes and bask in the warmth of life’s blessings. When you shine, you inspire others to do the same."
        });

        cards.Add(new TarotCard
        {
            cardName = "Judgment.",
            cardNumber = 20,
            description = "Judgment stands for reflection, reckoning, and awakening.\n\nIt signifies a time of personal growth and making meaningful decisions.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-judgement"),
            wisdom = "Reflect on your life and learn from past experiences. Now is the time to release guilt or regret and embrace renewal. True liberation comes from honest self-assessment."
        });

        cards.Add(new TarotCard
        {
            cardName = "The World.",
            cardNumber = 21,
            description = "The World represents completion, accomplishment, and wholeness.\n\nIt marks the end of a journey and the start of a new chapter.",
            cardImage = Resources.Load<Sprite>("Sprites/TarotCards/tarot-world"),
            wisdom = "Completion brings fulfillment. You have the power to bring things full circle and achieve your goals. Celebrate your accomplishments, knowing you are part of a larger whole."
        });
    }

    public void ShuffleDeck()
    {
        for (int j = 0; j < 11; j++)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                TarotCard temp = cards[i];
                int randomIndex = Random.Range(i, cards.Count);
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }

            j++;
        }
    }
}
