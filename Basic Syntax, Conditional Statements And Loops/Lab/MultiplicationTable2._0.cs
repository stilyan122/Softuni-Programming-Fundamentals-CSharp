using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multyplier = int.Parse(Console.ReadLine());
            if (multyplier > 10)
            {
                Console.WriteLine($"{n} X {multyplier} = {n * multyplier}");
            }
            else
            {
                for (int i = multyplier; i <= 10; i++)
                {
                    int multiply = n * i;
                    Console.WriteLine($"{n} X {i} = {multiply}");
                }
            }
        }
    }
}
