using System;
using System.Threading;

public class Card
{
	public int value { get; set; }
	public string name { get; set; }

	public Card(int value, string name) { this.value = value; this.name = name; }

    public void Art() {
		switch (this.name.ToLower())
		{
			case "aceofspades": ArtManager.AceOfSpades(); break;
            case "twoofspades": ArtManager.TwoOfSpades(); break;
            case "threeofspades": ArtManager.ThreeOfSpades(); break;
            case "fourofspades": ArtManager.FourOfSpades(); break;
            case "fiveofspades": ArtManager.FiveOfSpades(); break;
            case "sixofspades": ArtManager.SixOfSpades(); break;
            case "sevenofspades": ArtManager.SevenOfSpades(); break;
            case "eightofspades": ArtManager.EightOfSpades(); break;
            case "nineofspades": ArtManager.NineOfSpades(); break;
            case "tenofspades": ArtManager.TenOfSpades(); break;
            case "jackofspades": ArtManager.JackOfSpades(); break;
            case "queenofspades": ArtManager.QueenOfSpades(); break;
            case "kingofspades": ArtManager.KingOfSpades(); break;

            case "aceofdiamonds": ArtManager.AceOfDiamonds(); break;
            case "twoofdiamonds": ArtManager.TwoOfDiamonds(); break;
            case "threeofdiamonds": ArtManager.ThreeOfDiamonds(); break;
            case "fourofdiamonds": ArtManager.FourOfDiamonds(); break;
            case "fiveofdiamonds": ArtManager.FiveOfDiamonds(); break;
            case "sixofdiamonds": ArtManager.SixOfDiamonds(); break;
            case "sevenofdiamonds": ArtManager.SevenOfDiamonds(); break;
            case "eightofdiamonds": ArtManager.EightOfDiamonds(); break;
            case "nineofdiamonds": ArtManager.NineOfDiamonds(); break;
            case "tenofdiamonds": ArtManager.TenOfDiamonds(); break;
            case "jackofdiamonds": ArtManager.JackOfDiamonds(); break;
            case "queenofdiamonds": ArtManager.QueenOfDiamonds(); break;
            case "kingofdiamonds": ArtManager.KingOfDiamonds(); break;

            case "aceofclubs": ArtManager.AceOfClubs(); break;
            case "twoofclubs": ArtManager.TwoOfClubs(); break;
            case "threeofclubs": ArtManager.ThreeOfClubs(); break;
            case "fourofclubs": ArtManager.FourOfClubs(); break;
            case "fiveofclubs": ArtManager.FiveOfClubs(); break;
            case "sixofclubs": ArtManager.SixOfClubs(); break;
            case "sevenofclubs": ArtManager.SevenOfClubs(); break;
            case "eightofclubs": ArtManager.EightOfClubs(); break;
            case "nineofclubs": ArtManager.NineOfClubs(); break;
            case "tenofclubs": ArtManager.TenOfClubs(); break;
            case "jackofclubs": ArtManager.JackOfClubs(); break;
            case "queenofclubs": ArtManager.QueenOfClubs(); break;
            case "kingofclubs": ArtManager.KingOfClubs(); break;

            case "aceofhearts": ArtManager.AceOfHearts(); break;
            case "twoofhearts": ArtManager.TwoOfHearts(); break;
            case "threeofhearts": ArtManager.ThreeOfHearts(); break;
            case "fourofhearts": ArtManager.FourOfHearts(); break;
            case "fiveofhearts": ArtManager.FiveOfHearts(); break;
            case "sixofhearts": ArtManager.SixOfHearts(); break;
            case "sevenofhearts": ArtManager.SevenOfHearts(); break;
            case "eightofhearts": ArtManager.EightOfHearts(); break;
            case "nineofhearts": ArtManager.NineOfHearts(); break;
            case "tenofhearts": ArtManager.TenOfHearts(); break;
            case "jackofhearts": ArtManager.JackOfHearts(); break;
            case "queenofhearts": ArtManager.QueenOfHearts(); break;
            case "kingofhearts": ArtManager.KingOfHearts(); break;

            default: Console.WriteLine("No Art Found."); break;
        }
	}
}

public class CardManager
{
	public CardManager() { }

    public List<Card> playerDeck = new List<Card>();
    public List<Card> dealerDeck = new List<Card>();

    public bool gameOver = false;
    public bool playerWon = false;  // Result to send to BetManager

    private List<Card> drawnCards = new List<Card>();
    private Random rnd = new Random();

    private int playerScore = 0;
    private int dealerScore = 0;

    private bool playerStand = false;
    private bool dealerStand = false;
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
                case 1: card = new Card(1, "AceOfSpades"); break;
                case 2: card = new Card(2, "TwoOfSpades"); break;
                case 3: card = new Card(3, "ThreeOfSpades"); break;
                case 4: card = new Card(4, "FourOfSpades"); break;
                case 5: card = new Card(5, "FiveOfSpades"); break;
                case 6: card = new Card(6, "SixOfSpades"); break;
                case 7: card = new Card(7, "SevenOfSpades"); break;
                case 8: card = new Card(8, "EightOfSpades"); break;
                case 9: card = new Card(9, "NineOfSpades"); break;
                case 10: card = new Card(10, "TenOfSpades"); break;
                case 11: card = new Card(10, "JackOfSpades"); break;
                case 12: card = new Card(10, "QueenOfSpades"); break;
                case 13: card = new Card(10, "KingOfSpades"); break;

                case 14: card = new Card(1, "AceOfDiamonds"); break;
                case 15: card = new Card(2, "TwoOfDiamonds"); break;
                case 16: card = new Card(3, "ThreeOfDiamonds"); break;
                case 17: card = new Card(4, "FourOfDiamonds"); break;
                case 18: card = new Card(5, "FiveOfDiamonds"); break;
                case 19: card = new Card(6, "SixOfDiamonds"); break;
                case 20: card = new Card(7, "SevenOfDiamonds"); break;
                case 21: card = new Card(8, "EightOfDiamonds"); break;
                case 22: card = new Card(9, "NineOfDiamonds"); break;
                case 23: card = new Card(10, "TenOfDiamonds"); break;
                case 24: card = new Card(10, "JackOfDiamonds"); break;
                case 25: card = new Card(10, "QueenOfDiamonds"); break;
                case 26: card = new Card(10, "KingOfDiamonds"); break;

                case 27: card = new Card(1, "AceOfClubs"); break;
                case 28: card = new Card(2, "TwoOfClubs"); break;
                case 29: card = new Card(3, "ThreeOfClubs"); break;
                case 30: card = new Card(4, "FourOfClubs"); break;
                case 31: card = new Card(5, "FiveOfClubs"); break;
                case 32: card = new Card(6, "SixOfClubs"); break;
                case 33: card = new Card(7, "SevenOfClubs"); break;
                case 34: card = new Card(8, "EightOfClubs"); break;
                case 35: card = new Card(9, "NineOfClubs"); break;
                case 36: card = new Card(10, "TenOfClubs"); break;
                case 37: card = new Card(10, "JackOfClubs"); break;
                case 38: card = new Card(10, "QueenOfClubs"); break;
                case 39: card = new Card(10, "KingOfClubs"); break;

                case 40: card = new Card(1, "AceOfHearts"); break;
                case 41: card = new Card(2, "TwoOfHearts"); break;
                case 42: card = new Card(3, "ThreeOfHearts"); break;
                case 43: card = new Card(4, "FourOfHearts"); break;
                case 44: card = new Card(5, "FiveOfHearts"); break;
                case 45: card = new Card(6, "SixOfHearts"); break;
                case 46: card = new Card(7, "SevenOfHearts"); break;
                case 47: card = new Card(8, "EightOfHearts"); break;
                case 48: card = new Card(9, "NineOfHearts"); break;
                case 49: card = new Card(10, "TenOfHearts"); break;
                case 50: card = new Card(10, "JackOfHearts"); break;
                case 51: card = new Card(10, "QueenOfHearts"); break;
                case 52: card = new Card(10, "KingOfHearts"); break;

                default: card = new Card(0, "Joker?"); break;
            }

            foreach (Card c in drawnCards) { if (c.name.ToLower() == card.name.ToLower()) valid = false; break; }
        }
        while (!valid);

        return card;
    }

    public void StartGame()
    {
        drawnCards.Clear();
        playerDeck.Clear();
        dealerDeck.Clear();
        playerScore = 0;
        dealerScore = 0;

        playerDeck.Add(DealCard());
        playerDeck.Add(DealCard());
        dealerDeck.Add(DealCard());
        dealerDeck.Add(DealCard());
    }

    public void PlayerTurn()
    {
        // 
    }

    public void DealerTurn()
    {
        // 
    }

    public void Results() 
    {
        if ((playerScore > dealerScore && playerScore <= 21) || (dealerScore > 21)) playerWon = true;
        else playerWon = false;
    }
}
