using System;
public class GameManager
{
    bool keepPlaying = true;

    // Bet Manager
    BetManager betManager = new BetManager();

    // Card Manager
    CardManager cardManager = new CardManager();

    // Art Manager
    ArtManager artManager = new ArtManager();

    public GameManager()
    {
        // UI Manager? (Linking Art to Cards)
        UIManager.LinkArt(cardManager, artManager);
    }

    public void PlayGame()
    {
        while (keepPlaying)
        {
            if (betManager.playerChipCount <= 0)
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
        // Bet Manager
        Console.WriteLine("How much would you like to bet?");
        string betInput = Console.ReadLine();
        int parsedBet = int.Parse(betInput);
        parsedBet = betManager.PlaceBet(parsedBet);

        // Card Manager
        cardManager.StartGame();
        DisplayHands();

        // Player's Turn
        while (cardManager.playerStand == false)
        {
            HitOrStand();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    cardManager.PlayerTurn(true);
                    break;
                case "2":
                    cardManager.PlayerTurn(false);
                    break;
                default:
                    Console.WriteLine("Invalid input, try again");
                    break;
            }
        }

        // Dealer's Turn
        while (cardManager.gameOver == false && cardManager.dealerStand == false)
        {
            cardManager.DealerTurn(true);
        }

        // Final Results
        cardManager.Results();
        betManager.RoundFinished(cardManager.playerWon);
    }

    public void DisplayHands()
    {
        // Art Manager (Ascii Display)
        Console.WriteLine("-- Dealer --");
        artManager.DisplayMultipleCards(cardManager.dealerDeck);

        Console.WriteLine("\n-- You --");
        artManager.DisplayMultipleCards(cardManager.playerDeck);
    }

    public void HitOrStand()
    {
        Console.WriteLine("Hit or Stand?");
        Console.WriteLine("1 - Hit");
        Console.WriteLine("2 - Stand");
    }

    public void DisplayGameMenu()
    {
        Console.WriteLine("Welcome to Blackjack! Would you like to place a bet?");
        Console.WriteLine("1 - Yes, I'd like to place a bet");
        Console.WriteLine("2 - No thanks.");
    }
}