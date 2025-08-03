global using DiceGame.IO;
using System.Reflection.Metadata.Ecma335;
//Start Game
Game currentGame = new Game();
currentGame.Start();
//Roll Dice
Die rolledDie = new Die();
//User turn
while (currentGame.RemainingTries > 0)
{
    //Prompt user
    Console.WriteLine("Enter A Number: ");
    string guess = Console.ReadLine();
    //Begin turn
    Turn currentTurn = new Turn(guess, rolledDie.RolledNumber);

    //Check if user won
    if (currentGame.TakeTurn(currentTurn)) break;
    //Check if user lost
    if (currentGame.RemainingTries == 0) Console.WriteLine("You Lose");

}
//Game end
Game.End();
