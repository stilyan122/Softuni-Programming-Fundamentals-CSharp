using System;

namespace BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string currentKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heigh = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * heigh;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = currentKeg;

                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
