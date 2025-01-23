using System;
public class GameManager
{
    bool keepPlaying;
    int playersAmount;
 
    public GameManager()
    {
        // Bet Manager
        BetManager betManager = new BetManager();
 
        // Card Manager
        CardManager cardManager = new CardManager();
 
        keepPlaying = true;
        playersAmount = 1000;
    }
 
    public void PlayGame()
    {
 
        while (keepPlaying)
        {
            if (playersAmount <= 0)
            {
                keepPlaying = false;
            }
            DisplayGameMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    PlayRound();
                    break;
                case "2":
                    keepPlaying = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again");
                    break;
            }
        }
 
    }
 
    public void PlayRound()
    {
        // bet manager
        //  place bet
 
        // card manager
        // shuffle deck
        // deal to player and dealer
 
        // display
        DisplayHands();
 
    }
 
    public void DisplayHands()
    {
        // ascii display
    }
 
 
 
    public void DisplayGameMenu()
    {
        Console.WriteLine("Welcome to Black Jack! Would you like to place a bet?");
        Console.WriteLine("1 - Yes, I'd like to place a bet");
        Console.WriteLine("2 - No thanks.");
 
    }
 
}