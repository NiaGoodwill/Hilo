//creates score
score Score = new score();

// creates deck
Deck deck = new Deck();

string playAgain = "y";

while (playAgain == "y")
{
    Console.WriteLine("");

    Score.DisplayScore();

    Console.Write("The card is: ");
    Console.WriteLine(deck.DrawCard());

    Console.Write("Higher or lower? (h/l): ");
    string? choice = Console.ReadLine();

    Console.Write("Next Card is: ");
    Console.WriteLine(deck.DrawCard());

    

    Score.DisplayScore();

    Console.Write("Would you like to play again? (y/n): ");
    playAgain = Console.ReadLine().ToLower();
}





      


