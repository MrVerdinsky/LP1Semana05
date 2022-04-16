using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiates a random instance
            Random random = new Random();

            //Asks the user for a number of dices
            Console.Write("Insert number of dices to roll: ");
            byte nDices = Byte.Parse(Console.ReadLine());

            //Initiates the variable used to sum all dices
            int totalRolled = 0;

            //Loop used to sum each rolled dice based on
            //number of dices input by the user
            for (int i = 0; i < nDices; i++)
            {
               
                int diceRoll = random.Next(1, 7);
                Console.WriteLine($"Dice {i + 1}: {diceRoll}");
                totalRolled += diceRoll;
            }

            //Prints result of sum on screen
            Console.WriteLine($"Total rolled: {totalRolled}");
        }
    }
}
