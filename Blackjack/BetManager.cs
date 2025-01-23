using System;

public class BetManager
{
	public int playerChipCount { get; private set; }

	public int currentBet { get; private set; }

	public BetManager() {}



	/// <summary>
	/// Send in the amount of chips the player bet.
	/// If the amount is greater than the player's current chips it will automatically lower it to the proper amount.
	/// 
	///  RETURNS: The actual amount the player was able to bet
	/// </summary>
	public int PlaceBet(int amount)
	{
		if (amount > playerChipCount)
		{
			currentBet = playerChipCount;
		}
		else
		{
			currentBet = amount;
		}

		return currentBet;
	}



	/// <summary>
	/// Call when the round finishes, sets player's chips based on if the player won or not.
	/// 
	///  RETURNS: Player's original bet.
	/// </summary>
	public int RoundFinished(bool playerWon)
	{
		playerChipCount += (playerWon) ? currentBet : -currentBet;

		return currentBet;
	}


}
