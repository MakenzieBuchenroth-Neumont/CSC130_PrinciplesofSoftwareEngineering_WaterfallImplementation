using System;
public class GameManager
{
    bool keepPlaying = true;

    // Bet Manager
    BetManager betManager = new BetManager();

    // Card Manager
    CardManager cardManager = new CardManager();

    public GameManager()
    {
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
        bool playerWon = false;
        // bet manager
        Console.WriteLine("How much would you like to bet?");
        string betInput = Console.ReadLine();
        int parsedBet = int.Parse(betInput);
        parsedBet = betManager.PlaceBet(parsedBet);


        // card manager
        cardManager.StartGame();

        // display
        DisplayHands();
        while (cardManager.playerStand != true)
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

        while (cardManager.dealerStand != true)
        {
            cardManager.DealerTurn(true);
        }
        cardManager.Results();

        betManager.RoundFinished(cardManager.playerWon);

    }

    public void DisplayHands()
    {
        // ascii display
        foreach (Card card in cardManager.dealerDeck)
        {
            card.art();
        }


        foreach (Card card in cardManager.playerDeck)
        {
            card.art();
        }



    }

    public void HitOrStand()
    {
        Console.WriteLine("Hit or Stand?");
        Console.WriteLine("1 - Hit");
        Console.WriteLine("2 - Stand");

    }



    public void DisplayGameMenu()
    {
        Console.WriteLine("Welcome to Black Jack! Would you like to place a bet?");
        Console.WriteLine("1 - Yes, I'd like to place a bet");
        Console.WriteLine("2 - No thanks.");

    }

}