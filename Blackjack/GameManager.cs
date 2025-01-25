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
        Console.WriteLine("Welcome to Blackjack!\n");

        while (keepPlaying)
        {
            if (betManager.playerChipCount <= 0)
            {
                Console.WriteLine("Your balance is $0.\n");
                Console.WriteLine("Thank you for playing. Come again some time!\n");
                Console.WriteLine("Goodbye.\n");
                keepPlaying = false;
            }
            else
            {
                DisplayGameMenu();

                bool validInput;
                do
                {
                    validInput = true;
                    Console.Write("> ");

                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            PlayRound();
                            break;
                        case "2":
                            Console.WriteLine("\nSee you next time.\n");
                            Console.WriteLine("Goodbye!\n");
                            keepPlaying = false;
                            break;
                        default:
                            Console.WriteLine("\nInvalid input, please input 1 or 2.\n");
                            validInput = false;
                            break;
                    }
                } while (!validInput);
            }
        }
    }

    public void PlayRound()
    {
        // Bet Manager
        Console.WriteLine("\nHow much would you like to bet?\n");

        bool validBet;
        int parsedBet = 0;

        do
        {
            validBet = true;
            Console.Write("> $");

            try
            {
                string betInput = Console.ReadLine();
                parsedBet = int.Parse(betInput);
                parsedBet = betManager.PlaceBet(parsedBet);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nInvalid input, please enter a number.\n");
                validBet = false;
            }
        } while (!validBet);

        Console.WriteLine("\nBet placed for $" + parsedBet + ". Have fun!\n");

        // Card Manager
        cardManager.StartGame();
        DisplayHands();

        // Player's Turn
        while (cardManager.gameOver == false && cardManager.playerStand == false)
        {
            HitOrStand();
            bool validInput;

            do
            {
                validInput = true;
                Console.Write("> ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        cardManager.PlayerTurn(true);
                        Console.WriteLine("\nThe Dealer slides you a card.\n");
                        DisplayHands();
                        break;
                    case "2":
                        cardManager.PlayerTurn(false);
                        Console.WriteLine("\nIt is now the Dealer's turn.\n");
                        break;
                    default:
                        Console.WriteLine("Invalid input, please input 1 or 2.");
                        validInput = false;
                        break;
                }
            } while (!validInput);
        }

        // Dealer's Turn
        while (cardManager.gameOver == false && cardManager.dealerStand == false)
        {
            Console.WriteLine("...\n");

            cardManager.DealerTurn();

            if (cardManager.dealerStand == true) Console.WriteLine("The Dealer choses to stand.\n");
            else
            {
                Console.WriteLine("The Dealer slides themselves a card.\n");
                DisplayHands();
            }
        }

        // Final Results
        cardManager.Results();

        if (cardManager.playerWon == true) Console.WriteLine("You won!\n"); else Console.WriteLine("You lost. Better luck next time.\n");

        betManager.RoundFinished(cardManager.playerWon);
    }

    public void DisplayHands()
    {
        // Art Manager (Ascii Display)
        Console.WriteLine("-- Dealer --");
        artManager.DisplayMultipleCards(cardManager.dealerDeck);
        Console.WriteLine("\n(Score: " + cardManager.dealerScore + ")\n\n");

        Console.WriteLine("-- You --");
        artManager.DisplayMultipleCards(cardManager.playerDeck);
        Console.WriteLine("\n(Score: " + cardManager.playerScore + ")\n");
    }

    public void HitOrStand()
    {
        Console.WriteLine("Hit or Stand?");
        Console.WriteLine("1 - Hit");
        Console.WriteLine("2 - Stand\n");
    }

    public void DisplayGameMenu()
    {
        Console.WriteLine("Would you like to place a bet?  (Current Balance: $" + betManager.playerChipCount + ")\n");
        Console.WriteLine("1 - Yes, I'd like to place a bet.");
        Console.WriteLine("2 - No thanks.\n");
    }
}