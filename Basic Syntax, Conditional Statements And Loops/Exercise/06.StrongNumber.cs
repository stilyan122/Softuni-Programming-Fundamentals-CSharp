using System;

namespace StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            string number = num.ToString();
            foreach (var item in number)
            {
                int value = (int)item - 48;
                int factorial = 1;
                for (int i = 1; i <= value; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }

            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
