using System;

public class Turn
{
    private readonly string _guess;
    private readonly int _dieNumber;
    public int ParsedGuess { get; private set; }

    public Turn(string guess, int dieNumber)
    {
        _guess = guess;
        _dieNumber = dieNumber;

    }

    public bool CheckGuess()
    {
        ParsedGuess = InputValidator.AttemptParse(_guess);
        if (ParsedGuess == -1)
        {
            Console.WriteLine("Wrong Input");
            return false;
        }
        if (ParsedGuess == _dieNumber)
        {
            Console.WriteLine("You Win");
            return true;
        }


        Console.WriteLine("Wrong number");
        return false;

    }
}
