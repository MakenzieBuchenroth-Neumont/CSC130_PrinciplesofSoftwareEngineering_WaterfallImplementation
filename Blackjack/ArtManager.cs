using System;

public class ArtManager {
	public ArtManager() {}

    public void DisplayMultipleCards(List<Card> cards) {
        string line1 = "", line2 = "", line3 = "", line4 = "", line5 = "", line6 = "", art;
        int line;

        foreach (Card card in cards)
        {
            art = card.art();
            line = 1;

            foreach (char c in art)
            {
                if (c != '\n')
                {
                    switch (line)
                    {
                        case 1: line1 += c; break;
                        case 2: line2 += c; break;
                        case 3: line3 += c; break;
                        case 4: line4 += c; break;
                        case 5: line5 += c; break;
                        case 6: line6 += c; break;
                        default: line1 += c; break;
                    }
                }
                else
                {
                    switch (line)
                    {
                        case 1: line1 += "   "; break;
                        case 2: line2 += "   "; break;
                        case 3: line3 += "   "; break;
                        case 4: line4 += "   "; break;
                        case 5: line5 += "   "; break;
                        default: line1 += "   "; break;
                    }

                    line++;
                }
            }

            line6 += "   ";
        }

        line1 += "\n"; line2 += "\n"; line3 += "\n"; line4 += "\n"; line5 += "\n"; line6 += "\n";

        string display = line1 + line2 + line3 + line4 + line5 + line6;
        Console.Write(display);
    }

    #region Spades
    public string AceOfSpades() {
		string ascii =  " _____ " + "\n" +
						"|A .  |" + "\n" +
					   @"| /.\ |" + "\n" +
						"|(_._)|" + "\n" +
						"|  |  |" + "\n" +
						"|____Ɐ|";

        return ascii;
    }
    public string TwoOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|2 .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____ᘔ|";

        return ascii;
    }
    public string ThreeOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|3 .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____Ɛ|";

        return ascii;
    }
    public string FourOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|4 .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____߈|";

        return ascii;
    }
    public string FiveOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|5 .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____5|";

        return ascii;
    }
    public string SixOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|6 .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____9|";

        return ascii;
    }
    public string SevenOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|7 .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____L|";

        return ascii;
    }
    public string EightOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|8 .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____8|";

        return ascii;
    }
    public string NineOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|9 .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____6|";

        return ascii;
    }
    public string TenOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|10.  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|___0⇂|";

        return ascii;
    }
    public string JackOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|J .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____ᒋ|";

        return ascii;
    }
    public string QueenOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|Q .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____ტ|";

        return ascii;
    }
    public string KingOfSpades() {
        string ascii =  " _____ " + "\n" +
                        "|K .  |" + "\n" +
                       @"| /.\ |" + "\n" +
                        "|(_._)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____ꓘ|";

        return ascii;
    }
    #endregion
    #region Diamonds
    public string AceOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|A ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____Ɐ|";

        return ascii;
    }
    public string TwoOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|2 ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____ᘔ|";

        return ascii;
    }
    public string ThreeOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|3 ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____Ɛ|";

        return ascii;
    }
    public string FourOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|4 ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____߈|";

        return ascii;
    }
    public string FiveOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|5 ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____5|";

        return ascii;
    }
    public string SixOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|6 ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____9|";

        return ascii;
    }
    public string SevenOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|7 ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|___ㄥ|";

        return ascii;
    }
    public string EightOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|8 ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____8|";

        return ascii;
    }
    public string NineOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|9 ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____6|";

        return ascii;
    }
    public string TenOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|10^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|___0⇂|";

        return ascii;
    }
    public string JackOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|J ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____ᒋ|";

        return ascii;
    }
    public string QueenOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|Q ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____ტ|";

        return ascii;
    }
    public string KingOfDiamonds() {
        string ascii =  " _____ " + "\n" +
                        "|K ^  |" + "\n" +
                       @"| / \ |" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____ꓘ|";

        return ascii;
    }
    #endregion
    #region Clubs
    public string AceOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|A _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____Ɐ|";

        return ascii;
    }
    public string TwoOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|2 _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____ᘔ|";

        return ascii;
    }
    public string ThreeOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|3 _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____Ɛ|";

        return ascii;
    }
    public string FourOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|4 _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____߈|";

        return ascii;
    }
    public string FiveOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|5 _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____5|";

        return ascii;
    }
    public string SixOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|6 _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____9|";

        return ascii;
    }
    public string SevenOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|7 _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|___ㄥ|";

        return ascii;
    }
    public string EightOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|8 _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____8|";

        return ascii;
    }
    public string NineOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|9 _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____6|";

        return ascii;
    }
    public string TenOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|10_  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|___0⇂|";

        return ascii;
    }
    public string JackOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|J _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____ᒋ|";

        return ascii;
    }
    public string QueenOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|Q _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____ტ|";

        return ascii;
    }
    public string KingOfClubs() {
        string ascii =  " _____ " + "\n" +
                        "|K _  |" + "\n" +
                        "| ( ) |" + "\n" +
                        "|(_'_)|" + "\n" +
                        "|  |  |" + "\n" +
                        "|____ꓘ|";

        return ascii;
    }
    #endregion
    #region Hearts
    public string AceOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|A_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____Ɐ|";

        return ascii;
    }
    public string TwoOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|2_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____ᘔ|";

        return ascii;
    }
    public string ThreeOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|3_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____Ɛ|";

        return ascii;
    }
    public string FourOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|4_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____߈|";

        return ascii;
    }
    public string FiveOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|5_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____5|";

        return ascii;
    }
    public string SixOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|6_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____9|";

        return ascii;
    }
    public string SevenOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|7_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|___ㄥ|";

        return ascii;
    }
    public string EightOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|8_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____8|";

        return ascii;
    }
    public string NineOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|9_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____6|";

        return ascii;
    }
    public string TenOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|10 _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|___0⇂|";

        return ascii;
    }
    public string JackOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|J_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____ᒋ|";

        return ascii;
    }
    public string QueenOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|Q_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____ტ|";

        return ascii;
    }
    public string KingOfHearts() {
        string ascii =  " _____ " + "\n" +
                        "|K_ _ |" + "\n" +
                        "|( v )|" + "\n" +
                       @"| \ / |" + "\n" +
                        "|  .  |" + "\n" +
                        "|____ꓘ|";

        return ascii;
    }
	#endregion
}
