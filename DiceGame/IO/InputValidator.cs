using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.IO
{
    public static class InputValidator
    {
        public static int AttemptParse(string guess)
        {
            int parsedGuess;
            if (int.TryParse(guess, out parsedGuess)) return parsedGuess;

            Console.WriteLine("Incorrect input");
            return -1;

        }
    }
}
