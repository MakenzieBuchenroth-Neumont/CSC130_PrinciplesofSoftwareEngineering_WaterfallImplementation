namespace Blackjack {
	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Running program...\n");

            GameManager game = new GameManager();
			game.PlayGame();
		}
	}
}
