// See https://aka.ms/new-console-template for more information

score Score = new score();
Score.DisplayScore();


Deck deck = new Deck();

List<string> card = deck.DrawCard();
Console.Write("The card is: ");

Console.Write("Higher or lower? (Y/N): ");
Console.ReadLine();

Console.Write("Next Card is : ");
List <string> newcard = deck.DrawCard();






      


