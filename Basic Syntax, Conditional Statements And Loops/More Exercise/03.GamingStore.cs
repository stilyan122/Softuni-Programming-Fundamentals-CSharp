using System;

namespace GamingStore
{
    class GamingStore
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double spendMonney = 0;
            while (true)
            {
                string nameOfGame = Console.ReadLine();

                if (nameOfGame == "Game Time")
                {
                    break;
                }

                double gamePrice = 0;

                switch (nameOfGame)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        return;
                }
                if (gamePrice > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                currentBalance -= gamePrice;
                spendMonney += gamePrice;
                Console.WriteLine($"Bought {nameOfGame}");

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }


            }
            Console.WriteLine($"Total spent: ${spendMonney:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
