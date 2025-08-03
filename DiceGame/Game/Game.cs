using System;

public class Game
{
	private int _remainingTries;
	public int RemainingTries
	{
		get
		{
			return _remainingTries;
		}
		private set
		{
			_remainingTries = value;

		}
	}
	public Game ()
	{
		_remainingTries = 3;
	}
	public void Start() => Console.WriteLine($"Dice rolled. Guess what number it shows in {this.RemainingTries} tries");

	public bool TakeTurn(Turn turn)
	{
		bool result = turn.isUserCorrect();
		if (turn.ParsedGuess != -1) _remainingTries--;
		return result;
	}

	public static void End() => Console.ReadKey();
}
