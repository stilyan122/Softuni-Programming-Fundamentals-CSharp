using System;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                int help = 0;
                help = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                bool isGood = false;
                isGood = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", help, isGood);
                sum = 0;
                i = help;
            }
        }
    }
}
