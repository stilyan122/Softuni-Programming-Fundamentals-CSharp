using System;

namespace FloatingEquality
{
    class FloatingEquality
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (num1 < num2)
            {
                double num3 = num1;
                num1 = num2;
                num2 = num3;
            }
            if (num1 - num2 < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
