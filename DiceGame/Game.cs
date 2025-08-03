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
	public static void Start() => Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries");

    public void TakeTurn() => RemainingTries--;
	public static void End() => Console.ReadKey();
}
