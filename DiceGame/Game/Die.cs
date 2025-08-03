using System;

public class Die
{
    private readonly Random _random;
    private const int NumberOfSides = 6;
    public int RolledNumber { get; private set; }
	public Die()
	{
        _random = new Random();
        RolledNumber = _random.Next(1, NumberOfSides + 1);
    }
}
