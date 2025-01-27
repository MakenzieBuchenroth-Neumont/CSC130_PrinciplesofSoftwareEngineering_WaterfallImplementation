using System;
using System.Threading;

public class Card
{
	public int value { get; set; }
	public string name { get; set; }

	public Card(int value, string name) { this.value = value; this.name = name; }

    public delegate string Func();
    public Func art;
}

public class CardManager
{
	public CardManager() { }

    public List<Card> playerDeck = new List<Card>();
    public List<Card> dealerDeck = new List<Card>();

    public bool gameOver = false;
    public bool playerWon = false;  // Result to send to BetManager

    public bool playerStand = false;
    public bool dealerStand = false;

    #region CARDS
    public Card aceOfSpades = new Card(1, "AceOfSpades");
    public Card twoOfSpades = new Card(2, "TwoOfSpades");
    public Card threeOfSpades = new Card(3, "ThreeOfSpades");
    public Card fourOfSpades = new Card(4, "FourOfSpades");
    public Card fiveOfSpades = new Card(5, "FiveOfSpades");
    public Card sixOfSpades = new Card(6, "SixOfSpades");
    public Card sevenOfSpades = new Card(7, "SevenOfSpades");
    public Card eightOfSpades = new Card(8, "EightOfSpades");
    public Card nineOfSpades = new Card(9, "NineOfSpades");
    public Card tenOfSpades = new Card(10, "TenOfSpades");
    public Card jackOfSpades = new Card(10, "JackOfSpades");
    public Card queenOfSpades = new Card(10, "QueenOfSpades");
    public Card kingOfSpades = new Card(10, "KingOfSpades");

    public Card aceOfDiamonds = new Card(1, "AceOfDiamonds");
    public Card twoOfDiamonds = new Card(2, "TwoOfDiamonds");
    public Card threeOfDiamonds = new Card(3, "ThreeOfDiamonds");
    public Card fourOfDiamonds = new Card(4, "FourOfDiamonds");
    public Card fiveOfDiamonds = new Card(5, "FiveOfDiamonds");
    public Card sixOfDiamonds = new Card(6, "SixOfDiamonds");
    public Card sevenOfDiamonds = new Card(7, "SevenOfDiamonds");
    public Card eightOfDiamonds = new Card(8, "EightOfDiamonds");
    public Card nineOfDiamonds = new Card(9, "NineOfDiamonds");
    public Card tenOfDiamonds = new Card(10, "TenOfDiamonds");
    public Card jackOfDiamonds = new Card(10, "JackOfDiamonds");
    public Card queenOfDiamonds = new Card(10, "QueenOfDiamonds");
    public Card kingOfDiamonds = new Card(10, "KingOfDiamonds");

    public Card aceOfClubs = new Card(1, "AceOfClubs");
    public Card twoOfClubs = new Card(2, "TwoOfClubs");
    public Card threeOfClubs = new Card(3, "ThreeOfClubs");
    public Card fourOfClubs = new Card(4, "FourOfClubs");
    public Card fiveOfClubs = new Card(5, "FiveOfClubs");
    public Card sixOfClubs = new Card(6, "SixOfClubs");
    public Card sevenOfClubs = new Card(7, "SevenOfClubs");
    public Card eightOfClubs = new Card(8, "EightOfClubs");
    public Card nineOfClubs = new Card(9, "NineOfClubs");
    public Card tenOfClubs = new Card(10, "TenOfClubs");
    public Card jackOfClubs = new Card(10, "JackOfClubs");
    public Card queenOfClubs = new Card(10, "QueenOfClubs");
    public Card kingOfClubs = new Card(10, "KingOfClubs");

    public Card aceOfHearts = new Card(1, "AceOfHearts");
    public Card twoOfHearts = new Card(2, "TwoOfHearts");
    public Card threeOfHearts = new Card(3, "ThreeOfHearts");
    public Card fourOfHearts = new Card(4, "FourOfHearts");
    public Card fiveOfHearts = new Card(5, "FiveOfHearts");
    public Card sixOfHearts = new Card(6, "SixOfHearts");
    public Card sevenOfHearts = new Card(7, "SevenOfHearts");
    public Card eightOfHearts = new Card(8, "EightOfHearts");
    public Card nineOfHearts = new Card(9, "NineOfHearts");
    public Card tenOfHearts = new Card(10, "TenOfHearts");
    public Card jackOfHearts = new Card(10, "JackOfHearts");
    public Card queenOfHearts = new Card(10, "QueenOfHearts");
    public Card kingOfHearts = new Card(10, "KingOfHearts");
    #endregion

    public int playerScore = 0;
    public int dealerScore = 0;

    private List<Card> drawnCards = new List<Card>();
    private Random rnd = new Random();

    private bool isDealerOver17 = false;

    private Card DealCard()
    {
        Card card;
        bool valid;

        do
        {
            valid = true;

            switch (rnd.Next(1, 53))
            {
                case 1: card = aceOfSpades; break;
                case 2: card = twoOfSpades; break;
                case 3: card = threeOfSpades; break;
                case 4: card = fourOfSpades; break;
                case 5: card = fiveOfSpades; break;
                case 6: card = sixOfSpades; break;
                case 7: card = sevenOfSpades; break;
                case 8: card = eightOfSpades; break;
                case 9: card = nineOfSpades; break;
                case 10: card = tenOfSpades; break;
                case 11: card = jackOfSpades; break;
                case 12: card = queenOfSpades; break;
                case 13: card = kingOfSpades; break;

                case 14: card = aceOfDiamonds; break;
                case 15: card = twoOfDiamonds; break;
                case 16: card = threeOfDiamonds; break;
                case 17: card = fourOfDiamonds; break;
                case 18: card = fiveOfDiamonds; break;
                case 19: card = sixOfDiamonds; break;
                case 20: card = sevenOfDiamonds; break;
                case 21: card = eightOfDiamonds; break;
                case 22: card = nineOfDiamonds; break;
                case 23: card = tenOfDiamonds; break;
                case 24: card = jackOfDiamonds; break;
                case 25: card = queenOfDiamonds; break;
                case 26: card = kingOfDiamonds; break;

                case 27: card = aceOfClubs; break;
                case 28: card = twoOfClubs; break;
                case 29: card = threeOfClubs; break;
                case 30: card = fourOfClubs; break;
                case 31: card = fiveOfClubs; break;
                case 32: card = sixOfClubs; break;
                case 33: card = sevenOfClubs; break;
                case 34: card = eightOfClubs; break;
                case 35: card = nineOfClubs; break;
                case 36: card = tenOfClubs; break;
                case 37: card = jackOfClubs; break;
                case 38: card = queenOfClubs; break;
                case 39: card = kingOfClubs; break;

                case 40: card = aceOfHearts; break;
                case 41: card = twoOfHearts; break;
                case 42: card = threeOfHearts; break;
                case 43: card = fourOfHearts; break;
                case 44: card = fiveOfHearts; break;
                case 45: card = sixOfHearts; break;
                case 46: card = sevenOfHearts; break;
                case 47: card = eightOfHearts; break;
                case 48: card = nineOfHearts; break;
                case 49: card = tenOfHearts; break;
                case 50: card = jackOfHearts; break;
                case 51: card = queenOfHearts; break;
                case 52: card = kingOfHearts; break;

                default: card = aceOfSpades; break;
            }

            foreach (Card c in drawnCards) { if (c.name.ToLower() == card.name.ToLower()) valid = false; break; }
        }
        while (!valid);

        drawnCards.Add(card);
        return card;
    }

    private int CalculateScore(List<Card> deck)
    {
        int score = 0;
        List<Card> addAtEnd = new List<Card>();
        foreach (Card card in deck) 
        {
            if (card.value == 1)
            {
                addAtEnd.Add(card);
            }
            else
                score += card.value;
        }

        for (int i = addAtEnd.Count; i > 0; i--)
        {
            if (score + 11 + (i - 1) > 21)
            {
                score += 1;
            }
            else
            {
                score += 11;
            }
        }

        return score;
    }

    public void StartGame()
    {
        drawnCards.Clear();
        gameOver = false;
        playerWon = false;

        playerDeck.Clear();
        playerScore = 0;
        playerStand = false;

        dealerDeck.Clear();
        dealerScore = 0;
        dealerStand = false;

        playerDeck.Add(DealCard());
        playerDeck.Add(DealCard());
        playerScore = CalculateScore(playerDeck);

        dealerDeck.Add(DealCard());
        dealerDeck.Add(DealCard());
        dealerScore = CalculateScore(dealerDeck);
    }

    public void PlayerTurn(bool hit)
    {
        if (hit) 
        {
            playerDeck.Add(DealCard());
            playerScore = CalculateScore(playerDeck);

            if (playerScore > 21) gameOver = true;
        }
        else playerStand = true;
    }

    public void DealerTurn()
    {
        Thread.Sleep(3000); // Wait for 3 seconds

        if (dealerScore < 17)
        {
            dealerDeck.Add(DealCard());
            dealerScore = CalculateScore(dealerDeck);

            if (dealerScore > 21) gameOver = true;
        }
        else dealerStand = true;
    }

    public void Results() 
    {
        if ((playerScore > dealerScore && playerScore <= 21) || (dealerScore > 21)) playerWon = true;
        else playerWon = false;
    }
}
