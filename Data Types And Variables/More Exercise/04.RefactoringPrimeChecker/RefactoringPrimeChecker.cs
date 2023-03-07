using System;

namespace RefactoringPrimeChecker
{
    class RefactoringPrimeChecker
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int cepitel = 2; cepitel < i; cepitel++)
                {
                    if (i % cepitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine("{0} -> true ", i);
                }
                else
                {
                    Console.WriteLine("{0} -> false", i);
                }
            }
        }
    }
}
