using System;

namespace ConvertMetersToKilometers
{
    class PoundsToDollars
    {
        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            double km = m / 1000;
            Console.WriteLine($"{km:F2}");
        }
    }
}
