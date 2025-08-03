global using DiceGame.IO;
using System.Reflection.Metadata.Ecma335;
//Start Game
Game currentGame = new Game();
Game.Start();
//Roll Dice
Die rolledDie = new Die();
//User turn
while (currentGame.RemainingTries > 0)
{
    Console.WriteLine("Enter A Number: ");
    string guess = Console.ReadLine();
    Turn currentTurn = new Turn(guess, rolledDie.RolledNumber);

    if (currentGame.TakeTurn(currentTurn)) break;

    if (currentTurn.ParsedGuess == -1) continue;

    if (currentGame.RemainingTries == 0) Console.WriteLine("You Lose");

}
//Game end
Game.End();
