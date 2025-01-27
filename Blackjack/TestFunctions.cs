public static class Testing
{
    public static object[] Test_Art_Display()
    {
        ArtManager am = new ArtManager();
        bool passed = true;
        string info = "";

        // Test(s)


        return new object[] { passed, info };
    }

    public static object[] Test_Bet_Storage()
    {
        BetManager bm = new BetManager();
        bool passed = true;
        string info = "";

        // Test(s)
        if (bm.PlaceBet(100) != 100) { passed = false; info = "Bet was not set correctly."; }
        else if (bm.PlaceBet(10000) != bm.playerChipCount) { passed = false; info = "Bet can be higher than chip count/balance."; }
        else if (bm.PlaceBet(-10) < 0) { passed = false; info = "Bet can be negative."; }

        return new object[] { passed, info };
    }

    public static object[] Test_Card_Dealing()
    {
        CardManager cm = new CardManager();
        bool passed = true;
        string info = "";

        // Test(s)
        Card card = cm.DealCard();
        if (card != cm.drawnCards[0]) { passed = false; info = "Dealt card was not placed into list of drawn cards."; }

        return new object[] { passed, info };
    }
}