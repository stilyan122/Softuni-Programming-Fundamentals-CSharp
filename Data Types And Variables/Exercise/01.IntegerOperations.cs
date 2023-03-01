using System;

namespace IntegerOperations
{
    class IntegerOperations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int sum = a + b;
            int divide = sum / c;
            int x = divide * d;
            Console.WriteLine(x);
        }
    }
}
