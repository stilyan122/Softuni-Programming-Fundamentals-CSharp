using System;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int amountInTank = 0;

            for (int i = 0; i < n; i++)
            {
                int water = int.Parse(Console.ReadLine());

                bool isFull = water > 255;
                bool isOverflow = amountInTank + water > 255;

                if (isFull || isOverflow)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                amountInTank += water;
            }
            Console.WriteLine(amountInTank);
        }
    }
}
