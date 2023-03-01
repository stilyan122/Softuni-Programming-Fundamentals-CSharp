using System;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint sum = 0;
            while (number != 0)
            {
                uint x = number % 10;
                sum += x;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
