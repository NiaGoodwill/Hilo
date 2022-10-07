class Deck
{
    Random random = new Random();
    // the deck
    List<string> deck = new List<string>();
    // the complementary dictionary that provides values for each card in the deck
    Dictionary<string, int> deckInts = new Dictionary<string, int>();
    // list of suits for convenience
    List<string> suits = new List<string> {"Spades", "Hearts","Clubs", "Diamonds"};

    // constructor
    public Deck()
    {
        ShuffleDeck();
        CreateDict();
    }

    // replenish the deck. Remove all cards currently in the deck then add a full deck 
    void CollectCards()
    {
        if (deck.Count() != 0)
        {
            for ( int i = deck.Count() -1; i >= 0; i--)
                {
                    deck.RemoveAt(i);
                }
        }

        for (int i = 2; i <=10; i++)
        {
            deck.Add($"{i} of {suits[0]}");
            deck.Add($"{i} of {suits[1]}");
            deck.Add($"{i} of {suits[2]}");
            deck.Add($"{i} of {suits[3]}");
        }
        foreach (string suit in suits)
        {
            deck.Add($"Ace of {suit}");
            deck.Add($"Jack of {suit}");
            deck.Add($"Queen of {suit}");
            deck.Add($"King of {suit}");
        }
    }
    
    // Draw, display, and discard the first card in the deck
    public string DrawCard()
    {
        string card = deck[0];
        deck.RemoveAt(0);
        return card;
    }

    public void ShuffleDeck()
    {
        CollectCards();
        List<string> tempDeck = new List<string>();
        for ( int i = deck.Count() -1; i >= 0; i--)
        {
            tempDeck.Add(deck[i]);
            deck.RemoveAt(i);
        }
        while (tempDeck.Count() != 0)
        {
            int randomIndex = random.Next(tempDeck.Count());
            deck.Add(tempDeck[randomIndex]);
            tempDeck.RemoveAt(randomIndex);
        }
    }

    // take two cards and give the position (in terms of value) of the second relative to the first, higher "h", lower "l" or the same "s"
    public string RelativeCardPosition(string controlValueCard, string testCard)
    {
        if (deckInts[testCard] > deckInts[controlValueCard])
        {
            return "h";
        }
        else if (deckInts[testCard] < deckInts[controlValueCard])
        {
            return "l";
        }
        else
        {
            return "s";
        }
    }
    // Used at the start. Creates the numerical dictionary to give value to every card
    public void CreateDict()
    {
        for (int i = 2; i <=10; i++)
        {
            deckInts.Add($"{i} of {suits[0]}", i);
            deckInts.Add($"{i} of {suits[1]}", i);
            deckInts.Add($"{i} of {suits[2]}", i);
            deckInts.Add($"{i} of {suits[3]}", i);
        }
        foreach (string suit in suits)
        {
            deckInts.Add($"Ace of {suit}", 1);
            deckInts.Add($"Jack of {suit}", 11);
            deckInts.Add($"Queen of {suit}", 12);
            deckInts.Add($"King of {suit}", 13);
        }
    }
}