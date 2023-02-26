using System;

namespace SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num);
                sum += num;
                num += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
