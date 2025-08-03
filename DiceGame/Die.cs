using System;

public class Die
{
	private static Random _random = new Random();
    public int RolledNumber { get; private set; }
	public Die()
	{
        RolledNumber = _random.Next(1, 7);
    }
}
