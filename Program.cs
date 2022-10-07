// See https://aka.ms/new-console-template for more information

score Score = new score();
Score.DisplayScore();


Deck deck = new Deck();

Console.Write("The card is: ");
deck.DrawCard();

Console.Write("Higher or lower? (Y/N): ");
Console.ReadLine();

Console.Write("Next Card is : ");
deck.DrawCard();






      


