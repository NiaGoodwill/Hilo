class Deck
{
    List<string> cards = new List<string>();
    Random random = new Random();
    public Deck()
    {
        for (int i = 1; i <= 13; i++)
        {
            cards.Add($"A{i.ToString()}");
        }
        for (int i = 1; i <= 13; i++)
        {
            cards.Add($"B{i.ToString()}");
        }
        for (int i = 1; i <= 13; i++)
        {
            cards.Add($"C{i.ToString()}");
        }
        for (int i = 1; i <= 13; i++)
        {
            cards.Add($"D{i.ToString()}");
        }
    }
    
    public string DrawCard()
    {
        int randomIndentifier = random.Next(53);
        return cards[randomIndentifier];
    }

    public void ShuffleDeck()
    {

    }
}
