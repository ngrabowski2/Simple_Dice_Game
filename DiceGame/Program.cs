//Start Game
Game currentGame = new Game();
Game.Start();
//Roll Dice
Die rolledDie = new Die();
//DEBUG:
Console.WriteLine("DEBUG- rolled number: " + rolledDie.RolledNumber);
//User turn
while (currentGame.RemainingTries > 0)
{
    Console.WriteLine("Enter A Number: ");
    string guess = Console.ReadLine();
    int parsedGuess;
    bool validInput = int.TryParse(guess, out parsedGuess);
    if (!validInput)
    {
        Console.WriteLine("Incorrect input");
        continue;
    }
    if (parsedGuess == rolledDie.RolledNumber)
    {
        Console.WriteLine("You Win");
        break;
    } else
    {
        Console.WriteLine("Wrong number");
        currentGame.TakeTurn();
        if (currentGame.RemainingTries == 0) Console.WriteLine("You Lose");
    }
}
//Game end
Game.End();

//TODO: Once implementation is working, move turn to its own class to allow program to solely be a game manager