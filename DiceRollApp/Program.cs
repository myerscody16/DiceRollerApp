using System;

namespace DiceRollApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Hello, welcome to Grand Circus Casino! Would you like to roll the dice? (y/n)");
                string rollDiceQ = Console.ReadLine().ToLower();
                if (rollDiceQ == "y")
                {
                    Console.WriteLine("Here we go");
                }
                else if (rollDiceQ == "n")
                {
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid response, please try again");
                    continue;
                }
                RollTheDice();
                bool cont2 = true;
                while (cont2)
                {
                    Console.WriteLine("Would you like to run this program again?(y/n)");
                    string progAgain = Console.ReadLine().ToLower();
                    if (progAgain == "y")
                    {
                        break;
                    }
                    else if (progAgain == "n")
                    {
                        Console.WriteLine("Goodbye.");
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Response, please try again.");
                        continue;
                    }
                }
                continue;
            }
        }
        public static void RollTheDice()
        {
            Console.WriteLine("How many sides does the first die have?");
            string die1 = Console.ReadLine();
            int dieSide1 = int.Parse(die1);

            Console.WriteLine("How many sides does the second die have?");
            string die2 = Console.ReadLine();
            int dieSide2 = int.Parse(die2);

            Random rnd = new Random();
            int dice1 = rnd.Next(1,dieSide1);
            int dice2 = rnd.Next(1, dieSide2);

            Console.WriteLine($"You rolled a {dice1} and a {dice2}!");
        }
    }  
}
