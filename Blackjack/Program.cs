namespace Blackjack {
	internal class Program {
		static void Main(string[] args) {
#if DEBUG
			Console.WriteLine("Testing Mode\n");
			
			object[] tAD = Testing.Test_Art_Display();
			Console.WriteLine($"Art Display Test\nPassed: {(bool)tAD[0]}");
            if ((bool)tAD[0] == false) Console.WriteLine($"Reason: {(string)tAD[1]}\n"); else Console.Write("\n");

            object[] tBS = Testing.Test_Bet_Storage();
            Console.WriteLine($"Bet Storage Test\nPassed: {(bool)tBS[0]}");
            if ((bool)tBS[0] == false) Console.WriteLine($"Reason: {(string)tBS[1]}\n"); else Console.Write("\n");

            object[] tCD = Testing.Test_Card_Dealing();
            Console.WriteLine($"Card Dealing Test\nPassed: {(bool)tCD[0]}");
            if ((bool)tCD[0] == false) Console.WriteLine($"Reason: {(string)tCD[1]}\n"); else Console.Write("\n");
#endif
            Console.WriteLine("Running program...\n");

            GameManager game = new GameManager();
			game.PlayGame();

            Console.WriteLine("Exiting program...");
        }
	}
}
